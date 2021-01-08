using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shared.ApiModels
{
    [ExcludeFromCodeCoverage]
    public class TimeStampModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime LastOnline { get; set; }
    }
}
