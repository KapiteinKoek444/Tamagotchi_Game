func @_Shared.Extensions.Consul.StartupConfig.RegisterConfiguration$Microsoft.Extensions.DependencyInjection.IServiceCollection.Microsoft.Extensions.Configuration.IConfiguration$(none, none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :10 :8) {
^entry (%_services : none, %_configuration : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :10 :65)
cbde.store %_services, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :10 :65)
%1 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :10 :99)
cbde.store %_configuration, %1 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :10 :99)
br ^0

^0: // JumpBlock
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :12 :12) // Not a variable of known type: services
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :12 :53) // Not a variable of known type: configuration
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :12 :78) // "Configuration" (StringLiteralExpression)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :12 :53) // configuration.GetSection("Configuration") (InvocationExpression)
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :12 :12) // services.Configure<ConfigurationSetting>(configuration.GetSection("Configuration")) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :13 :34) // Not a variable of known type: services
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :13 :34) // services.BuildServiceProvider() (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :14 :22) // Not a variable of known type: serviceProvider
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :14 :22) // serviceProvider.GetService<IOptions<ConfigurationSetting>>() (InvocationExpression)
%13 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :15 :19) // Not a variable of known type: iop
%14 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :15 :19) // iop.Value (SimpleMemberAccessExpression)
return %14 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\Consul\\StartupConfig.cs" :15 :12)

^1: // ExitBlock
cbde.unreachable

}
