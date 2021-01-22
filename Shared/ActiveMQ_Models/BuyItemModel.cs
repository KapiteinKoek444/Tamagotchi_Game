using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shared.Shared.ActiveMQ_Models
{
    [ExcludeFromCodeCoverage]
	public class BuyItemModel
	{
		public Guid itemId { get; set; }
		public Guid userId { get; set; }
	}
}
