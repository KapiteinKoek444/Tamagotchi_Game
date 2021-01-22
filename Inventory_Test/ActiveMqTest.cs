using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Tamago_Inventory.Controllers;

namespace Inventory_Test
{
	[TestClass]
	public class ActiveMqTest
	{
		int seed = 888;

		ActiveMQLog logger;
		ActiveMQController controller;

		[TestInitialize]
		public void init()
		{
			var uri = "tcp://82.169.80.49:61616";
			var username = "admin";
			var password = "admin";

			logger = new ActiveMQLog(uri, username, password);

			controller = new ActiveMQController(new MongoClient("mongodb+srv://matthijs:matthijs@cluster0.5iro2.azure.mongodb.net/?retryWrites=true&w=majority"), logger);
		}

		[TestCleanup]
		public void clean()
		{

		}

		[TestMethod]
		public void GetTest()
		{
			string expectedString = "activeMq controller loaded";

			var returnData = controller.Get();
			string actualString = returnData.Result;

			Assert.AreEqual(expectedString, actualString, "failed - unable to get result.");
		}
	}
}
