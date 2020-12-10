using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamago_Inventory.Models;

namespace Tamago_Inventory.Controllers
{
	[ApiController]
	[Route("rest")]
	public class RestController : Controller
	{
		private IMongoCollection<InventoryDTO> _inventoryCollection;

		public RestController(IMongoClient client)
		{
			var database = client.GetDatabase("Inventory_Database");
			_inventoryCollection = database.GetCollection<InventoryDTO>("CInventory");
		}

		[HttpGet]
		public IEnumerable<InventoryDTO> Get()
		{
			var data = _inventoryCollection.Find(Builders<InventoryDTO>.Filter.Empty).ToList();
			return data;
		}

		[HttpGet("{id}")]
		public InventoryDTO Get([FromRoute] Guid id)
		{
			var filter = Builders<InventoryDTO>.Filter.Eq("userId", id);
			var data = _inventoryCollection.Find(filter).First();
			return data;
		}

		[HttpDelete("{id}")]
		[Route("remove/{id}")]
		public InventoryDTO Remove([FromRoute] Guid id)
		{
			var filter = Builders<InventoryDTO>.Filter.Eq("userId", id);
			var data = _inventoryCollection.FindOneAndDelete(filter);
			return data;
		}

		[HttpPost]
		[Route("post")]
		public IActionResult Post([FromBody] InventoryDTO inv)
		{
			_inventoryCollection.InsertOne(inv);
			return StatusCode(StatusCodes.Status201Created, inv);
		}

		[HttpPost("{id}")]
		[Route("new/{id}")]
		public IActionResult Post([FromRoute] Guid id)
		{
			InventoryDTO inv = new InventoryDTO();
			inv.id = Guid.NewGuid();
			inv.userId = id;
			inv.itemId = new List<Guid>();
			_inventoryCollection.InsertOne(inv);
			return StatusCode(StatusCodes.Status201Created, inv);
		}
	}
}
