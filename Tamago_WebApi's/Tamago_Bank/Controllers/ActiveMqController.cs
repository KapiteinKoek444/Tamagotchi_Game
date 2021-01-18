using Apache.NMS;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ActiveMQ_Models;
using Shared.Shared.ApiModels;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace Tamago_Bank.Controllers
{
	[ApiController]
	[Route("active")]
	public class ActiveMQController : Controller
	{
		private IMongoCollection<WalletModel> _bankcollection;
		private readonly IActiveMqLog _activeMQLog;

		public ActiveMQController(IMongoClient client, IActiveMqLog activeMQLog)
		{
			var database = client.GetDatabase("Bank_Database");
			_bankcollection = database.GetCollection<WalletModel>("CWallet");
			_activeMQLog = activeMQLog;

			ListenToMessage();
		}

		[ExcludeFromCodeCoverage]
		private async void ListenToMessage()
		{
			_activeMQLog.ConnectListener("Shop.buyItem.queue");
			var listener = _activeMQLog.GetMessageConsumer();

			listener.Listener += new MessageListener(UponMessage);
		}

		[ExcludeFromCodeCoverage]
		private async void UponMessage(IMessage received)
		{
			_activeMQLog.ConnectSender("Bank.buyItemResponse.queue");
			var producer = _activeMQLog.GetMessageProducer();
			ITextMessage objectMessage = received as ITextMessage;
			ItemModel m = _activeMQLog.ConvertIMessageToObject<ItemModel>(objectMessage);
			Guid id = m.userId;
			var filter = Builders<WalletModel>.Filter.Eq("userId", id);
			var allData = _bankcollection.Find(Builders<WalletModel>.Filter.Empty).ToList();
			var data = allData.Where(x => x.userId == id).FirstOrDefault();

			if (data.balance < m.price)
				m.confirmation = false;
			else
				m.confirmation = true;

			WalletModel currWallet = _bankcollection.Find(x => x.userId == id).FirstOrDefault();
			currWallet.balance = currWallet.balance - m.price;
			_bankcollection.ReplaceOne(x => x.userId.Equals(currWallet.userId), currWallet, new ReplaceOptions { IsUpsert = true });

			var res = _activeMQLog.ConvertObjectToIMessage<ItemModel>(m);
			producer.Send(res);
		}

		[HttpGet]
		public async Task<string> Get()
		{
			return "activeMq controller loaded";
		}
	}
}
