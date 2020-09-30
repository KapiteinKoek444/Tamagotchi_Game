using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB_API.Entities;

namespace MongoDB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController : ControllerBase
    {
        private IMongoCollection<Animal> AnimalCollection;

        public AnimalController(IMongoClient client)
        {
            var database = client.GetDatabase("PetAnimals");
            AnimalCollection = database.GetCollection<Animal>("Animals");
        }

        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return AnimalCollection.Find(Builders<Animal>.Filter.Empty).ToList();
        }

        [HttpGet("{id}")]
        public Animal Get([FromRoute] Guid id)
        {
            var filter = Builders<Animal>.Filter.Eq("UserId", id);
            return AnimalCollection.Find(filter).First();
        }

        [HttpPost]
        public IActionResult Post([FromBody] Animal model)
        {
            try
            {
                AnimalCollection.InsertOne(model);
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        [HttpPost("{id}")]
        public IActionResult Update([FromRoute] Guid id,[FromBody] Animal model)
        {
            try
            {
                var result = AnimalCollection.ReplaceOneAsync(a => a.UserId.Equals(id),model, new UpdateOptions { IsUpsert = true });
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
