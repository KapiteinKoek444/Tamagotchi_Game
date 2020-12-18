using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Shared.ActiveMQ_Models
{
	public class RequestItemResponseModel
	{
		public Guid userId;
		public List<FoodModel> items;
	}
}
