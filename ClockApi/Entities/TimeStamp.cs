using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace ClockApi.Entities
{
    [ExcludeFromCodeCoverage]
    public class TimeStamp
    {
        [BsonId]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime LastOnline { get; set; }
    }
}
