using Apache.NMS;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ActiveMQ_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamago_Inventory.Models;

namespace Tamago_Inventory.Controllers
{
	[ApiController]
	[Route("active")]
	public class ActiveMQController : Controller
	{
		private IMongoCollection<InventoryDTO> _inventoryCollection;
		
		private readonly IActiveMqLog _activeMQLogShop;
		private readonly IActiveMqLog _activeMQLog;
		
		private RequestItemResponseModel response = new RequestItemResponseModel();
		private bool received = false;

		public ActiveMQController(IMongoClient client, IActiveMqLog activeMQLog)
		{
			var database = client.GetDatabase("Inventory_Database");
			_inventoryCollection = database.GetCollection<InventoryDTO>("CInventory");

			//Activemq logs
			_activeMQLogShop = activeMQLog;
			_activeMQLog = activeMQLog;

			ListenToMessage();
		}

		public async void ListenToMessage()
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
			var filter = Builders<InventoryDTO>.Filter.Eq("userId", id);
			var data = _inventoryCollection.Find(filter).First();
			WaitForFood(data);
			return response.items;
		}

		public async Task<string> WaitForFood(InventoryDTO data)
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

		public async void UponShopGetMessage(IMessage message)
		{
			ITextMessage objectMessage = message as ITextMessage;
			response = _activeMQLog.ConvertIMessageToObject<RequestItemResponseModel>(objectMessage);
			received = true;
		}

		public async void UponShopBuyMessage(IMessage message)
		{

			_activeMQLogShop.ConnectSender("Inv.shopAddSend.queue");
			var producer = _activeMQLogShop.GetMessageProducer();

			ITextMessage objectMessage = message as ITextMessage;
			var response = _activeMQLogShop.ConvertIMessageToObject<ItemModel>(objectMessage);

			var filter = Builders<InventoryDTO>.Filter.Eq("userId", response.userId);

			var data = _inventoryCollection.Find(filter).First();
			data.itemId.Add(response.itemId);

			var update = Builders<InventoryDTO>.Update.Set("itemId", data.itemId);

			_inventoryCollection.UpdateOne(filter, update);

			producer.Send(objectMessage);
		}

		[HttpGet]
		public async void Get()
		{

		}
	}
}
