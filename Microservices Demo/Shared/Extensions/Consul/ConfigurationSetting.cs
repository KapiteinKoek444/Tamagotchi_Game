using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Shared.Extensions.Consul
{
    [ExcludeFromCodeCoverage]
    public class ConfigurationSetting
    {
        public string ServiceName { get; set; }
        public string ServiceHost { get; set; }
        public int ServicePort { get; set; }
        public string ConsulAddress { get; set; }
    }
}
