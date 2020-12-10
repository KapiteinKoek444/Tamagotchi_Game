using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamago_Shop.Models;

namespace Tamago_Shop.Controllers
{
	[ApiController]
	[Route("rest")]
	public class RestController : Controller
	{
		private IMongoCollection<FoodDTO> _foodCollection;

		public RestController(IMongoClient client)
		{
			var database = client.GetDatabase("Shop_Database");
			_foodCollection = database.GetCollection<FoodDTO>("CFood");
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IEnumerable<FoodDTO> Get()
		{
			var data = _foodCollection.Find(Builders<FoodDTO>.Filter.Empty).ToList();
			return data;
		}

		[HttpGet("{id}")]
		public FoodDTO Get([FromRoute] Guid id)
		{
			var filter = Builders<FoodDTO>.Filter.Eq("id", id);
			var data = _foodCollection.Find(filter).First();
			return data;
		}

		[HttpDelete("{id}")]
		[Route("remove/{id}")]
		public FoodDTO Remove([FromRoute] Guid id)
		{
			var filter = Builders<FoodDTO>.Filter.Eq("id", id);
			var data = _foodCollection.FindOneAndDelete(filter);
			return data;
		}

		[HttpPost]
		[Route("post")]
		public IActionResult Post([FromBody] FoodDTO food)
		{
			_foodCollection.InsertOne(food);
			return StatusCode(StatusCodes.Status201Created, food);
		}

		[Route("test")]
		public void PushFood()
		{
			FoodDTO food = new FoodDTO();
			food.id = Guid.NewGuid();
			food.name = "Red-cow";
			food.category = "soda";
			food.price = 1.5;
			food.discount = 0.0;

			food.foodVal = 3;
			food.energyVal = 8;
			food.happyVal = 2;

			Post(food);
		}
	}
}
