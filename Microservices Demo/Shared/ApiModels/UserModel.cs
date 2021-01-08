using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shared.Shared.ApiModels
{
    [ExcludeFromCodeCoverage]
	public class UserModel
	{
		public Guid Id { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
