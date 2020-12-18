using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apache.NMS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using MongoDB.Bson;
using MongoDB.Driver;
using Shared.ActiveMQ_Models;
using Shared.ApiModels;
using TamagotchiAnimalAPI.Entities;
using Shared.Extensions.ActiveMQ;
using TamagotchiAnimalAPI.Extentions;
using TamagotchiAnimalAPI.factories;
using TamagotchiAnimalAPI.SignalR;

namespace TamagotchiAnimalAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private IMongoCollection<Animal> _animalCollection;
        private readonly IHubContext<AnimalValuesHub> _hubContext;

        protected static ITextMessage message = null;
        private readonly IActiveMqLog _activeMQLog;

        public AnimalController(IMongoClient client, IActiveMqLog activeMQLog, IHubContext<AnimalValuesHub> hubContext)
        {
            var database = client.GetDatabase("PetAnimals");
            _animalCollection = database.GetCollection<Animal>("Animals");
            _activeMQLog = activeMQLog;
            _hubContext = hubContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = _animalCollection.Find(Builders<Animal>.Filter.Empty).ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var filter = Builders<Animal>.Filter.Eq("UserId", id);
            var result = _animalCollection.Find(filter).First();
            return Ok(result);
        }

        [HttpGet("ConnectAnimal/{id}")]
        public async Task<IActionResult> ConnectAnimal([FromRoute] Guid id)
        {
            Animal animal = (Animal)await Get(id);

            if (animal == null)
                return StatusCode(StatusCodes.Status500InternalServerError, "Animal not found..");

            _activeMQLog.ConnectSender("Clock.GetUserTimeStamp.queue");
            _activeMQLog.ConnectListener("Clock.GetUserTimeStampResponse.queue");

            using (IMessageConsumer consumer = _activeMQLog.GetMessageConsumer())
            {
                using (IMessageProducer producer = _activeMQLog.GetMessageProducer())
                {
                    // Start the connection so that messages will be processed.
                    producer.DeliveryMode = MsgDeliveryMode.Persistent;
                    consumer.Listener += new MessageListener(UponClockMessage);

                    // Send a message
                    RequestEntityModel requestmodel = new RequestEntityModel()
                    {
                        id = id,
                    };
                    IMessage request = _activeMQLog.ConvertObjectToIMessage<RequestEntityModel>(requestmodel);
                    producer.Send(request);

                    // Wait for the message
                    while (message == null) await Task.Delay(40);
                }
            }

            TimeStampModel receivedModel = _activeMQLog.ConvertIMessageToObject<TimeStampModel>(message);
            //reset message 
            message = null;

            var result = AnimalFactory.CalculateAnimalScore(animal, receivedModel.LastOnline);

            var updateAnimal = await Update(id, result);

            var timerFactory = new TimerFactory(() => _hubContext.Clients.All.SendAsync("getAnimalData", result));
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Animal model)
        {

            var animals = _animalCollection.Find(Builders<Animal>.Filter.Empty).ToList();
            var animal = animals.SingleOrDefault(x => x.UserId == model.UserId);

            if (animal != null)
                return StatusCode(StatusCodes.Status500InternalServerError, null);

            _animalCollection.InsertOne(model);
            return StatusCode(StatusCodes.Status201Created, model);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] Animal model)
        {
            try
            {
                _animalCollection.ReplaceOneAsync(a => a.UserId.Equals(id), model, new UpdateOptions { IsUpsert = true });
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        public async void UponClockMessage(IMessage message)
        {
            ITextMessage objectMessage = message as ITextMessage;
            message = objectMessage;
        }
    }
}
