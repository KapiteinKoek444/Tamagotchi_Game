using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Shared.Shared.ApiModels;
using Shop_Test.Factory;
using System.Collections.Generic;
using Tamago_Shop.Controllers;

namespace Shop_Test
{
	[TestClass]
	public class RestApiTest
	{
		RestController controller;
		List<FoodModel> models;

		int amount = 10;
		int seed = 888;

		[TestInitialize]
		public void Init()
		{
			controller = new RestController(new MongoClient("mongodb+srv://matthijs:matthijs@cluster0.5iro2.azure.mongodb.net/?retryWrites=true&w=majority"));
			models = Food_Factory.GenerateFood(amount, seed);

			foreach (var model in models)
				controller.Post(model);
		}

		[TestCleanup]
		public void Clean()
		{
			foreach (var model in models)
				controller.Remove(model.id);
		}

		[TestMethod]
		public void GetOneTest()
		{
			FoodModel expected = models[2];

			FoodModel actual = controller.Get(models[2].id);

			Assert.AreEqual(expected.id, actual.id, "failed - unable to get data.");
		}

		[TestMethod]
		public void GetAllTest()
		{
			foreach (var model in models)
			{
				FoodModel expected = model;
				FoodModel actual = controller.Get(model.id);
				Assert.AreEqual(expected.id, actual.id, "failed - unable to get data with id: " + expected.id + ".");
			}
		}

		[TestMethod]
		public void RemoveTest()
		{
			FoodModel expected = models[1];
			controller.Remove(expected.id);

			FoodModel actual = controller.Get(expected.id);

			Assert.AreEqual(null, actual, "failed - unable to remove item.");
		}

		[TestMethod]
		public void PostTest()
		{
			FoodModel expected = Food_Factory.GenerateFood(seed);
			controller.Post(expected);
			models.Add(expected);

			FoodModel actual = controller.Get(expected.id);

			Assert.AreEqual(expected.id, actual.id, "failed - unable to add item.");
		}
	}
}
