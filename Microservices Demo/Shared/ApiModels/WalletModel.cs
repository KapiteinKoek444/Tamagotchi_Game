using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shared.Shared.ApiModels
{
    [ExcludeFromCodeCoverage]
	public class WalletModel
	{
		public Guid id { get; set; }
		public Guid userId { get; set; }
		public double balance { get; set; }
	}
}
