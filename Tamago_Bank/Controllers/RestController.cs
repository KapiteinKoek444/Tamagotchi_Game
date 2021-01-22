using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tamago_Bank.Controllers
{
	[ApiController]
	[Route("rest")]
	public class RestController : Controller
	{
		private IMongoCollection<WalletModel> _walletCollection;

		public RestController(IMongoClient client)
		{
			var database = client.GetDatabase("Bank_Database");
			_walletCollection = database.GetCollection<WalletModel>("CWallet");
		}

		[HttpGet]
		public IEnumerable<WalletModel> Get()
		{
			var data = _walletCollection.Find(Builders<WalletModel>.Filter.Empty).ToList();
			return data;
		}

		[HttpGet("{id}")]
		public WalletModel Get([FromRoute] Guid id)
		{
			var filter = Builders<WalletModel>.Filter.Eq("userId", id);
			var data = _walletCollection.Find(filter).FirstOrDefault();
			return data;
		}

		[HttpDelete("{id}")]
		[Route("remove/{id}")]
		public WalletModel Remove([FromRoute] Guid id)
		{
			var filter = Builders<WalletModel>.Filter.Eq("userId", id);
			var data = _walletCollection.FindOneAndDelete(filter);
			return data;
		}

		[HttpPost]
		[Route("post")]
		public IActionResult Post([FromBody] WalletModel wallet)
		{
			_walletCollection.ReplaceOneAsync(x => x.userId.Equals(wallet.userId), wallet, new ReplaceOptions { IsUpsert = true });
			return StatusCode(StatusCodes.Status201Created, wallet);
		}

		[HttpPost("{id}")]
		[Route("addMoney/{id}")]
		public IActionResult AddToWallet([FromRoute] Guid id, [FromBody] double amount)
		{
			var filter = Builders<WalletModel>.Filter.Eq("userId", id);
			WalletModel data = _walletCollection.Find(filter).FirstOrDefault();

			data.balance += amount;

			_walletCollection.ReplaceOneAsync(x => x.userId.Equals(data.userId), data, new ReplaceOptions { IsUpsert = true });

			return StatusCode(StatusCodes.Status201Created, amount);
		}

		[HttpPost("{id}")]
		[Route("new/{id}")]
		public WalletModel Post([FromRoute] Guid id)
		{
			WalletModel wallet = new WalletModel();
			wallet.id = Guid.NewGuid();
			wallet.balance = 1000;
			wallet.userId = id;
			_walletCollection.InsertOne(wallet);
			return wallet;
		}
	}
}
