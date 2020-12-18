using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Shared.ApiModels
{
	public class InventoryModel
	{ 
		public Guid id { get; set; }
		public Guid userId { get; set; }
		public List<Guid> itemId { get; set; }
	}
}
