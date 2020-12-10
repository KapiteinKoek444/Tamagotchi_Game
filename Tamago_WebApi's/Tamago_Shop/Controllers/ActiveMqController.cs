using Apache.NMS;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ActiveMQ_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamago_Shop.Models;

namespace Tamago_Shop.Controllers
{
	[ApiController]
	[Route("active")]
	public class ActiveMQController : Controller
	{
		private IMongoCollection<FoodDTO> _foodCollection;
		private readonly IActiveMqLog _activeMQLogBank;
		private readonly IActiveMqLog _activeMQLogInv;
		private readonly IActiveMqLog _activeMQLogInvItems;
		private bool added = false;

		public ActiveMQController(IMongoClient client, IActiveMqLog activeMQLog)
		{
			var database = client.GetDatabase("Shop_Database");
			_foodCollection = database.GetCollection<FoodDTO>("CFood");

			//ActivemqLogs
			_activeMQLogBank = activeMQLog;
			_activeMQLogInv = activeMQLog;
			_activeMQLogInvItems = activeMQLog;

			ListenToMessage();
		}

		public async void ListenToMessage()
		{
			//Bank
			_activeMQLogBank.ConnectListener("Bank.buyItemResponse.queue");
			var bankListener = _activeMQLogBank.GetMessageConsumer();
			bankListener.Listener += new MessageListener(UponBankMessage);
			//Inv
			_activeMQLogInv.ConnectListener("Inv.shopAddSend.queue");
			var invListener = _activeMQLogInv.GetMessageConsumer();
			invListener.Listener += new MessageListener(UponInvMessage);

			_activeMQLogInvItems.ConnectListener("Inv.idSender.queue");
			var invGetListeneer = _activeMQLogInvItems.GetMessageConsumer();
			invGetListeneer.Listener += new MessageListener(UponInvGetMessage);
		}

		[HttpPost]
		[Route("buyfood")]
		public async Task<string> BuyFood([FromBody] BuyItemModel model)
		{
			var filter = Builders<FoodDTO>.Filter.Eq("id", model.itemId);
			var data = _foodCollection.Find(filter).First();

			//send the request
			Task<string> reply = AddFoodToInventory(data, model.userId);
			var r = reply.ToString();
			return r;
		}

		public async Task<string> AddFoodToInventory(FoodDTO food, Guid userId)
		{
			ItemModel model = new ItemModel();
			model.itemId = food.id;
			model.price = food.price - food.discount;
			model.userId = userId;

			_activeMQLogBank.ConnectSender("Shop.buyItem.queue");
			var producer = _activeMQLogBank.GetMessageProducer();
			var message = _activeMQLogBank.ConvertObjectToIMessage<ItemModel>(model);
			producer.Send(message);

			while (added == false)
			{
				await Task.Delay(40);
			}

			return "bought item!";
		}

		public async void UponBankMessage(IMessage message)
		{
			ITextMessage objectMessage = message as ITextMessage;
			ItemModel received = _activeMQLogBank.ConvertIMessageToObject<ItemModel>(objectMessage);

			if (received.confirmation)
			{
				_activeMQLogBank.ConnectSender("Inv.shopAddReceive.queue");
				var producer = _activeMQLogBank.GetMessageProducer();
				producer.Send(received);
			}
		}

		public async void UponInvMessage(IMessage message)
		{
			ITextMessage objectMessage = message as ITextMessage;
			ItemModel received = _activeMQLogInv.ConvertIMessageToObject<ItemModel>(objectMessage);

			if (received.confirmation)
				added = true;
		}

		public async void UponInvGetMessage(IMessage message)
		{
			_activeMQLogInvItems.ConnectSender("Inv.foodReceive.queue");
			var producer = _activeMQLogInvItems.GetMessageProducer();

			ITextMessage objectMessage = message as ITextMessage;
			RequestItemModel model = _activeMQLogInvItems.ConvertIMessageToObject<RequestItemModel>(objectMessage);
			RequestItemResponseModel response = new RequestItemResponseModel();

			response.userId = model.userId;
			response.items = new List<FoodModel>();

			foreach(var i in model.Items)
			{
				var filter = Builders<FoodDTO>.Filter.Eq("id", i);
				var data = _foodCollection.Find(filter).First();
				FoodModel m = new FoodModel();

				m.id = data.id;
				m.name = data.name;
				m.category = data.category;
				m.price = data.price;
				m.discount = data.discount;
				m.foodVal = data.foodVal;
				m.energyVal = data.energyVal;
				m.happyVal = data.happyVal;

				response.items.Add(m);
			}

			producer.Send(response);
		}

		[HttpGet]
		public async void Get()
		{

		}
	}
}
