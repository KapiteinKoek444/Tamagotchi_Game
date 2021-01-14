using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TamagotchiAnimalAPI.Entities
{
    [ExcludeFromCodeCoverage]
    public class Animal
    {
        [BsonId]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public float Food { get; set; }
        public float Energy { get; set; }
        public float Happiness { get; set; }
        public float Experience { get; set; }
        public int Level { get; set; }
        public int AnimalType { get; set; }
    }
}
