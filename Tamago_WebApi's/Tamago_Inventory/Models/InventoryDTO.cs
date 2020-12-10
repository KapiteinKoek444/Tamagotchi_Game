using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamago_Inventory.Models
{
	public class InventoryDTO
	{
		[BsonId]
		public Guid id { get; set; }
		public Guid userId { get; set; }
		public List<Guid> itemId { get; set; }
	}
}
