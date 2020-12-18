using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ClockApi.Entities
{
    public class TimeStamp
    {
        [BsonId]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime LastOnline { get; set; }
    }
}
