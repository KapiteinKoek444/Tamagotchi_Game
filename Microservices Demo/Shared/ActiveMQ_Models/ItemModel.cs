using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Shared.ActiveMQ_Models
{
	public class ItemModel
	{
		public Guid itemId;
		public Guid userId;

		public double price;
		public bool confirmation;
	}
}
