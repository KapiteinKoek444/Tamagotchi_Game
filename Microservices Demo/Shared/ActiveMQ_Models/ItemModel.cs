using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Shared.ActiveMQ_Models
{
    [ExcludeFromCodeCoverage]
	public class ItemModel
	{
		public Guid itemId;
		public Guid userId;

		public double price;
		public bool confirmation;
	}
}
