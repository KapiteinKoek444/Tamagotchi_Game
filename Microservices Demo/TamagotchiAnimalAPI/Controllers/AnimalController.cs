using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Apache.NMS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_API.Entities;
using Shared.Extensions.ActiveMQ;

namespace MongoDB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private IMongoCollection<Animal> _animalCollection;
        private readonly IActiveMqLog _activeMQLog;

        public AnimalController(IMongoClient client, IActiveMqLog activeMQLog)
        {
            var database = client.GetDatabase("PetAnimals");
            _animalCollection = database.GetCollection<Animal>("Animals");
            _activeMQLog = activeMQLog;
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
    }
}
