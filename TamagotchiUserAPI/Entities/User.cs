using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Diagnostics.CodeAnalysis;

namespace MongoDB_API.Entities
{
    [BsonIgnoreExtraElements]
    [ExcludeFromCodeCoverage]
    public class User
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
