using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tamago_Bank.Models;

namespace Tamago_Bank.Controllers
{
	[ApiController]
	[Route("rest")]
	public class RestController : Controller
	{
		private IMongoCollection<WalletDTO> _walletCollection;

		public RestController(IMongoClient client)
		{
			var database = client.GetDatabase("Bank_Database");
			_walletCollection = database.GetCollection<WalletDTO>("CWallet");
		}

		[HttpGet]
		public IEnumerable<WalletDTO> Get()
		{
			var data = _walletCollection.Find(Builders<WalletDTO>.Filter.Empty).ToList();
			return data;
		}

		[HttpGet("{id}")]
		public WalletDTO Get([FromRoute] Guid id)
		{
			var filter = Builders<WalletDTO>.Filter.Eq("userId", id);
			var data = _walletCollection.Find(filter).First();
			return data;
		}

		[HttpDelete("{id}")]
		[Route("remove/{id}")]
		public WalletDTO Remove([FromRoute] Guid id)
		{
			var filter = Builders<WalletDTO>.Filter.Eq("userId", id);
			var data = _walletCollection.FindOneAndDelete(filter);
			return data;
		}

		[HttpPost]
		[Route("post")]
		public IActionResult Post([FromBody] WalletDTO wallet)
		{
			_walletCollection.InsertOne(wallet);
			return StatusCode(StatusCodes.Status201Created, wallet);
		}

		[HttpPost("{id}")]
		[Route("new/{id}")]
		public IActionResult Post([FromRoute] Guid id)
		{
			WalletDTO wallet = new WalletDTO();
			wallet.id = Guid.NewGuid();
			wallet.balance = 1000;
			wallet.userId = id;
			_walletCollection.InsertOne(wallet);
			return StatusCode(StatusCodes.Status201Created, wallet);
		}
	}
}
