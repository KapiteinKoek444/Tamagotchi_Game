using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TamagotchiAnimalAPI.Entities
{
    public class Animal
    {
        [BsonId]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public float Food { get; set; }
        public float Energy { get; set; }
        public float Happiness { get; set; }
        public int AnimalType { get; set; }
    }
}
