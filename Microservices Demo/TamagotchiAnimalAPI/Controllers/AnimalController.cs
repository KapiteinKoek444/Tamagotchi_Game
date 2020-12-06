﻿using System;
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
        private IMongoCollection<Animal> AnimalCollection;
        private readonly IActiveMqLog _activeMQLog;

        public AnimalController(IMongoClient client, IActiveMqLog activeMQLog)
        {
            var database = client.GetDatabase("PetAnimals");
            AnimalCollection = database.GetCollection<Animal>("Animals");
            _activeMQLog = activeMQLog;
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

            var animals = AnimalCollection.Find(Builders<Animal>.Filter.Empty).ToList();
            var animal = animals.SingleOrDefault(x => x.UserId == model.UserId);

            if (animal != null)
                return StatusCode(StatusCodes.Status500InternalServerError, null);

            AnimalCollection.InsertOne(model);
            return StatusCode(StatusCodes.Status201Created, model);
        }

        [HttpPost("{id}")]
        public IActionResult Update([FromRoute] Guid id, [FromBody] Animal model)
        {
            try
            {
                AnimalCollection.ReplaceOneAsync(a => a.UserId.Equals(id), model, new UpdateOptions { IsUpsert = true });
                return StatusCode(StatusCodes.Status201Created, model);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
