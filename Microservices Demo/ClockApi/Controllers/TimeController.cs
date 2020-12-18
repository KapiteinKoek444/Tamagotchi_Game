using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apache.NMS;
using ClockApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ApiModels;

namespace ClockApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private IMongoCollection<TimeStamp> _TimeStampCollection;
        private readonly IActiveMqLog _activeMQLog;

        public TimeController(IMongoClient client, IActiveMqLog activeMQLog)
        {
            var database = client.GetDatabase("TimeData");
            _TimeStampCollection = database.GetCollection<TimeStamp>("UserTimeStamp");

            _activeMQLog = activeMQLog;
            _activeMQLog.ConnectListener("Clock.GetUserTimeStamp.queue");
            _activeMQLog.GetMessageConsumer().Listener += new MessageListener(UponAnimalMessage);
        }

        // GET: api/<TimeController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _TimeStampCollection.Find(Builders<TimeStamp>.Filter.Empty).ToList();
            return Ok(result);
        }


        // GET api/<TimeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var filter = Builders<TimeStamp>.Filter.Eq("UserId", id);
            var result = _TimeStampCollection.Find(filter).First();
            return Ok(result);
        }

        // POST api/<TimeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TimeStamp model)
        {
            var TimeStamps = _TimeStampCollection.Find(Builders<TimeStamp>.Filter.Empty).ToList();
            var user = TimeStamps.SingleOrDefault(x => x.UserId == model.UserId);

            if (user != null)
            {
                model.LastOnline = DateTime.Now;
                var result = _TimeStampCollection.ReplaceOneAsync(a => a.Id.Equals(user.Id), model, new UpdateOptions { IsUpsert = true });
                return StatusCode(StatusCodes.Status201Created, model);
            }

            _TimeStampCollection.InsertOne(model);
            return StatusCode(StatusCodes.Status201Created, model);
        }

        [HttpGet]
        [Route("Test")]
        public void Test()
        {
            TimeStamp test = new TimeStamp();
            test.Id = Guid.NewGuid();
            test.UserId = Guid.NewGuid();
            test.LastOnline = DateTime.Now;
            Post(test);
        }
        public async void UponAnimalMessage(IMessage message)
        {
            ITextMessage objectMessage = message as ITextMessage;
            AnimalModel receivedModel = _activeMQLog.ConvertIMessageToObject<AnimalModel>(objectMessage);

            var timestamp = (TimeStamp)await Get(receivedModel.UserId);

            if (timestamp == null)
            {
                timestamp = new TimeStamp() {Id = Guid.NewGuid(), UserId = receivedModel.UserId , LastOnline = DateTime.Now};
                await Post(timestamp);
            }

            _activeMQLog.ConnectSender("Clock.GetUserTimeStampResponse.queue");
            var producer = _activeMQLog.GetMessageProducer();
            producer.Send(timestamp);
        }


    }
}
