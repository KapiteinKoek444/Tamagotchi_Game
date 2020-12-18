using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.ApiModels
{
    public class TimeStampModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime LastOnline { get; set; }
    }
}
