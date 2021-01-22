using Shared.Shared.ApiModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing_Shared.Factory
{
	public static class Wallet_Factory
	{
		public static WalletModel GenerateWallet(int seed)
		{
			var r = new Random(seed);
			WalletModel wallet = new WalletModel();

			wallet.id = Guid.NewGuid();
			wallet.userId = Guid.NewGuid();
			wallet.balance = r.Next(0, 1000) + r.NextDouble();

			return wallet;
		}

		public static List<WalletModel> GenerateWallet(int amount, int seed)
		{
			List<WalletModel> wallets = new List<WalletModel>();

			for (int i = 0; i < amount; i++)
				wallets.Add(GenerateWallet(seed));

			return wallets;
		}
	}
}
