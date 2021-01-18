func @_Tamago_Bank.Program.Main$string$$$(none) -> () loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Program.cs" :15 :2) {
^entry (%_args : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Program.cs" :15 :26)
cbde.store %_args, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Program.cs" :15 :26)
br ^0

^0: // SimpleBlock
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: CreateHostBuilder
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Program.cs" :17 :21) // Not a variable of known type: args
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Program.cs" :17 :3) // CreateHostBuilder(args) (InvocationExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Program.cs" :17 :3) // CreateHostBuilder(args).Build() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Program.cs" :17 :3) // CreateHostBuilder(args).Build().Run() (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
