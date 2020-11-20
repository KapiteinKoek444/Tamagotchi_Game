using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Extensions.Consul
{
    public class ConfigurationSetting
    {
        public string ServiceName { get; set; }
        public string ServiceHost { get; set; }
        public int ServicePort { get; set; }
        public string ConsulAddresss { get; set; }
    }
}
