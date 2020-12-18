using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Shared.ApiModels
{
	public class WalletModel
	{
		public Guid id { get; set; }
		public Guid userId { get; set; }
		public double balance { get; set; }
	}
}
