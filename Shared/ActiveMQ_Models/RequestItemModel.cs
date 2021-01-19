using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Shared.ActiveMQ_Models
{
    [ExcludeFromCodeCoverage]
	public class RequestItemModel
	{
		public Guid userId;
		public List<Guid> Items;
	}
}
