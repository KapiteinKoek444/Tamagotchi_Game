using Inventory_Test.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using Tamago_Inventory.Controllers;

namespace Inventory_Test
{
	[TestClass]
	public class RestApiTest
	{
		RestController controller;
		List<InventoryModel> models;

		int amount = 10;
		int seed = 888;

		[TestInitialize]
		public void Init()
		{
			controller = new RestController(new MongoClient("mongodb+srv://matthijs:matthijs@cluster0.5iro2.azure.mongodb.net/?retryWrites=true&w=majority"));
			models = Inventory_Factory.GenerateInventory(amount, seed);

			foreach (var model in models)
				controller.Post(model);
		}

		[TestCleanup]
		public void Clean()
		{
			foreach (var model in models)
				controller.Remove(model.userId);
		}

		[TestMethod]
		public void GetOneTest()
		{
			InventoryModel expected = models[2];

			InventoryModel actual = controller.Get(models[2].userId);

			Assert.AreEqual(expected.id, actual.id, "failed - unable to get data.");
		}

		[TestMethod]
		public void GetAllTest()
		{
			foreach (var model in models)
			{
				InventoryModel expected = model;
				InventoryModel actual = controller.Get(model.userId);
				Assert.AreEqual(expected.id, actual.id, "failed - unable to get data with id: " + expected.id + ".");
			}
		}

		[TestMethod]
		public void RemoveTest()
		{
			InventoryModel expected = models[1];
			controller.Remove(expected.userId);

			InventoryModel actual = controller.Get(expected.id);

			Assert.AreEqual(null, actual, "failed - unable to remove item.");
		}

		[TestMethod]
		public void PostTest()
		{
			InventoryModel expected = Inventory_Factory.GenerateInventory(seed);
			controller.Post(expected);
			models.Add(expected);

			InventoryModel actual = controller.Get(expected.userId);

			Assert.AreEqual(expected.id, actual.id, "failed - unable to add item.");
		}

		[TestMethod]
		public void NewTest()
		{
			Guid userId = Guid.NewGuid();
			InventoryModel expected = controller.Post(userId);

			InventoryModel actual = controller.Get(expected.userId);

			Assert.AreEqual(expected.id, actual.id, "failed - unable to generate new item.");
		}
	}
}
