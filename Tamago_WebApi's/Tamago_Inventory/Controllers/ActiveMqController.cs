using Apache.NMS;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ActiveMQ_Models;
using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Tamago_Inventory.Controllers
{
	[ApiController]
	[Route("active")]
	public class ActiveMQController : Controller
	{
		private IMongoCollection<InventoryModel> _inventoryCollection;
		
		private readonly IActiveMqLog _activeMQLogShop;
		private readonly IActiveMqLog _activeMQLog;
		
		private RequestItemResponseModel response = new RequestItemResponseModel();
		private bool received = false;

		public ActiveMQController(IMongoClient client, IActiveMqLog activeMQLog)
		{
			var database = client.GetDatabase("Inventory_Database");
			_inventoryCollection = database.GetCollection<InventoryModel>("CInventory");

			//Activemq logs
			_activeMQLogShop = activeMQLog;
			_activeMQLog = activeMQLog;

			ListenToMessage();
		}

		[ExcludeFromCodeCoverage]
		private async void ListenToMessage()
		{
			//Shop
			_activeMQLogShop.ConnectListener("Inv.shopAddReceive.queue");
			var ShopListener = _activeMQLogShop.GetMessageConsumer();
			ShopListener.Listener += new MessageListener(UponShopBuyMessage);

			//Food
			_activeMQLog.ConnectListener("Inv.foodReceive.queue");
			var listener = _activeMQLog.GetMessageConsumer();
			listener.Listener += new MessageListener(UponShopGetMessage);

		}

		[HttpGet("{id}")]
		[Route("get/{id}")]
		public async Task<List<FoodModel>> GetFood([FromRoute] Guid id)
		{
			var filter = Builders<InventoryModel>.Filter.Eq("userId", id);
			var data = _inventoryCollection.Find(filter).First();
			await WaitForFood(data);
			return response.items;
		}

		[ExcludeFromCodeCoverage]
		private async Task<string> WaitForFood(InventoryModel data)
		{
			RequestItemModel model = new RequestItemModel();
			model.Items = data.itemId;
			model.userId = data.userId;
			_activeMQLog.ConnectSender("Inv.idSender.queue");
			var producer = _activeMQLog.GetMessageProducer();
			var message = _activeMQLog.ConvertObjectToIMessage<RequestItemModel>(model);
			producer.Send(message);

			while (received == false)
			{
				Task.Delay(40);
			}

			return "";
		}

		[ExcludeFromCodeCoverage]
		private async void UponShopGetMessage(IMessage message)
		{
			ITextMessage objectMessage = message as ITextMessage;
			response = _activeMQLog.ConvertIMessageToObject<RequestItemResponseModel>(objectMessage);
			received = true;
		}

		[ExcludeFromCodeCoverage]
		private async void UponShopBuyMessage(IMessage message)
		{

			_activeMQLogShop.ConnectSender("Inv.shopAddSend.queue");
			var producer = _activeMQLogShop.GetMessageProducer();

			ITextMessage objectMessage = message as ITextMessage;
			var response = _activeMQLogShop.ConvertIMessageToObject<ItemModel>(objectMessage);

			var filter = Builders<InventoryModel>.Filter.Eq("userId", response.userId);

			var data = _inventoryCollection.Find(filter).First();
			data.itemId.Add(response.itemId);

			var update = Builders<InventoryModel>.Update.Set("itemId", data.itemId);

			_inventoryCollection.UpdateOne(filter, update);

			producer.Send(objectMessage);
		}

		[HttpGet]
		public async Task<string> Get()
		{
			return "activeMq controller loaded";
		}
	}
}
