using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tamago_Shop.Controllers
{
	[ApiController]
	[Route("rest")]
	public class RestController : Controller
	{
		private IMongoCollection<FoodModel> _foodCollection;

		public RestController(IMongoClient client)
		{
			var database = client.GetDatabase("Shop_Database");
			_foodCollection = database.GetCollection<FoodModel>("CFood");
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IEnumerable<FoodModel> Get()
		{
			var data = _foodCollection.Find(Builders<FoodModel>.Filter.Empty).ToList();
			return data;
		}

		[HttpGet("{id}")]
		public FoodModel Get([FromRoute] Guid id)
		{
			var filter = Builders<FoodModel>.Filter.Eq("id", id);
			var data = _foodCollection.Find(filter).FirstOrDefault();
			return data;
		}

		[HttpDelete("{id}")]
		[Route("remove/{id}")]
		public FoodModel Remove([FromRoute] Guid id)
		{
			var filter = Builders<FoodModel>.Filter.Eq("id", id);
			var data = _foodCollection.FindOneAndDelete(filter);
			return data;
		}

		[HttpPost]
		[Route("post")]
		public IActionResult Post([FromBody] FoodModel food)
		{
			_foodCollection.InsertOne(food);
			return StatusCode(StatusCodes.Status201Created, food);
		}

		[Route("test")]
		public void PushFood()
		{
			FoodModel food = new FoodModel();
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
