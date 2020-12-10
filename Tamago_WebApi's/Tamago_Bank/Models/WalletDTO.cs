using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamago_Bank.Models
{
	public class WalletDTO
	{
		[BsonId]
		public Guid id { get; set; }
		public Guid userId { get; set; }
		public double balance { get; set; }
	}
}
