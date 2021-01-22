using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tamago_Inventory.Controllers
{
	[ApiController]
	[Route("rest")]
	public class RestController : Controller
	{
		private IMongoCollection<InventoryModel> _inventoryCollection;

		public RestController(IMongoClient client)
		{
			var database = client.GetDatabase("Inventory_Database");
			_inventoryCollection = database.GetCollection<InventoryModel>("CInventory");
		}

		[HttpGet]
		public IEnumerable<InventoryModel> Get()
		{
			var data = _inventoryCollection.Find(Builders<InventoryModel>.Filter.Empty).ToList();
			return data;
		}

		[HttpGet("{id}")]
		public InventoryModel Get([FromRoute] Guid id)
		{
			var filter = Builders<InventoryModel>.Filter.Eq("userId", id);
			var data = _inventoryCollection.Find(filter).FirstOrDefault();
			return data;
		}

		[HttpDelete("{id}")]
		[Route("remove/{id}")]
		public InventoryModel Remove([FromRoute] Guid id)
		{
			var filter = Builders<InventoryModel>.Filter.Eq("userId", id);
			var data = _inventoryCollection.FindOneAndDelete(filter);
			return data;
		}

		[HttpPost]
		[Route("post")]
		public async Task<IActionResult> Post([FromBody] InventoryModel inv)
		{
			await _inventoryCollection.ReplaceOneAsync(x => x.userId.Equals(inv.userId), inv, new ReplaceOptions { IsUpsert = true });
			return Ok(inv);
		}

		[HttpPost("{id}")]
		[Route("new/{id}")]
		public InventoryModel Post([FromRoute] Guid id)
		{
			InventoryModel inv = new InventoryModel();
			inv.id = Guid.NewGuid();
			inv.userId = id;
			inv.itemId = new List<Guid>();
			_inventoryCollection.InsertOne(inv);
			return inv;
		}
	}
}
