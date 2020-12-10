using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamago_Shop.Models
{
	public class FoodDTO
	{
		[BsonId]
		public Guid id { get; set; }

		public string name { get; set; }
		public string category { get; set; }

		public double price { get; set; }
		public double discount { get; set; }

		public double foodVal { get; set; }
		public double energyVal { get; set; } 
		public double happyVal { get; set; }
	}
}
