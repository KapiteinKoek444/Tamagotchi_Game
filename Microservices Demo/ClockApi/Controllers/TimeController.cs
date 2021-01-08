using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Apache.NMS;
using ClockApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MongoDB.Driver;
using Shared.ActiveMQ_Models;
using Shared.ApiModels;
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
        public async Task<List<TimeStamp>> Get()
        {
            var result = _TimeStampCollection.Find(Builders<TimeStamp>.Filter.Empty).ToList();
            return result;
        }


        // GET api/<TimeController>/5
        [HttpGet("{id}")]
        public async Task<TimeStamp> Get([FromRoute] Guid id)
        {
            var filter = Builders<TimeStamp>.Filter.Eq("UserId", id);
            var result = _TimeStampCollection.Find(filter).FirstOrDefault();
            return result;
        }

        // POST api/<TimeController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TimeStamp model)
        {
            var filter = Builders<TimeStamp>.Filter.Eq("UserId", model.UserId);
            var user = _TimeStampCollection.Find(filter).FirstOrDefault();

            if (user != null)
            {
                model.LastOnline = DateTime.Now;
                var result = _TimeStampCollection.ReplaceOneAsync(a => a.Id.Equals(user.Id), model, new UpdateOptions { IsUpsert = true });
                return StatusCode(StatusCodes.Status201Created, model);
            }

            _TimeStampCollection.InsertOne(model);
            return StatusCode(StatusCodes.Status201Created, model);
        }
        [HttpPost("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] TimeStamp model)
        {
            try
            {
                _TimeStampCollection.ReplaceOneAsync(a => a.UserId.Equals(id), model, new UpdateOptions { IsUpsert = true });
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpDelete("{id}")]
        [Route("remove/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<TimeStamp> Remove([FromRoute] Guid id)
        {
            var filter = Builders<TimeStamp>.Filter.Eq("id", id);
            var data = _TimeStampCollection.FindOneAndDelete(filter);
            return data;
        }



        [HttpGet]
        [Route("Test")]
        [ExcludeFromCodeCoverage]
        public void Test()
        {
            TimeStamp test = new TimeStamp();
            test.Id = Guid.NewGuid();
            test.UserId = Guid.NewGuid();
            test.LastOnline = DateTime.Now;
            Post(test);
        }
        [ExcludeFromCodeCoverage]
        public async void UponAnimalMessage(IMessage message)
        {
            ITextMessage objectMessage = message as ITextMessage;
            RequestEntityModel receivedModel = _activeMQLog.ConvertIMessageToObject<RequestEntityModel>(objectMessage);

            var filter = Builders<TimeStamp>.Filter.Eq("UserId", receivedModel.id);
            var timestamp = _TimeStampCollection.Find(filter).FirstOrDefault();
            

            if (timestamp == null)
            {
                timestamp = new TimeStamp() {Id = Guid.NewGuid(), UserId = receivedModel.id, LastOnline = DateTime.Now};
                await Post(timestamp);
            }

            _activeMQLog.ConnectSender("Clock.GetUserTimeStampResponse.queue");
            var producer = _activeMQLog.GetMessageProducer();

            producer.Send(new TimeStampModel() { Id = timestamp.Id, UserId = timestamp.UserId, LastOnline = timestamp.LastOnline});
            timestamp.LastOnline = DateTime.Now;

            await Update(timestamp.UserId,timestamp);

        }


    }
}
