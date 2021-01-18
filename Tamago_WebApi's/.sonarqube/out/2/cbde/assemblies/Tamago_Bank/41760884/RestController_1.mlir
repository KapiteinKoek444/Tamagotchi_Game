func @_Tamago_Bank.Controllers.RestController.Get$$() -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :22 :2) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :25 :14) // Not a variable of known type: _walletCollection
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :25 :37) // Builders<WalletModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :25 :37) // Builders<WalletModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :25 :37) // Builders<WalletModel>.Filter.Empty (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :25 :14) // _walletCollection.Find(Builders<WalletModel>.Filter.Empty) (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :25 :14) // _walletCollection.Find(Builders<WalletModel>.Filter.Empty).ToList() (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :26 :10) // Not a variable of known type: data
return %7 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :26 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Bank.Controllers.RestController.Get$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :29 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :30 :25)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :30 :25)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :32 :16) // Builders<WalletModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :32 :16) // Builders<WalletModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :32 :48) // "userId" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :32 :58) // Not a variable of known type: id
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :32 :16) // Builders<WalletModel>.Filter.Eq("userId", id) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :33 :14) // Not a variable of known type: _walletCollection
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :33 :37) // Not a variable of known type: filter
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :33 :14) // _walletCollection.Find(filter) (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :33 :14) // _walletCollection.Find(filter).FirstOrDefault() (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :34 :10) // Not a variable of known type: data
return %12 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :34 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Bank.Controllers.RestController.Remove$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :37 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :39 :28)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :39 :28)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :41 :16) // Builders<WalletModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :41 :16) // Builders<WalletModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :41 :48) // "userId" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :41 :58) // Not a variable of known type: id
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :41 :16) // Builders<WalletModel>.Filter.Eq("userId", id) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :42 :14) // Not a variable of known type: _walletCollection
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :42 :49) // Not a variable of known type: filter
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :42 :14) // _walletCollection.FindOneAndDelete(filter) (InvocationExpression)
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :43 :10) // Not a variable of known type: data
return %11 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :43 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Bank.Controllers.RestController.Post$Shared.Shared.ApiModels.WalletModel$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :46 :2) {
^entry (%_wallet : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :48 :28)
cbde.store %_wallet, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :48 :28)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :50 :3) // Not a variable of known type: _walletCollection
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :50 :31) // Not a variable of known type: wallet
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :50 :3) // _walletCollection.InsertOne(wallet) (InvocationExpression)
// Entity from another assembly: StatusCode
// Entity from another assembly: StatusCodes
%4 = constant 201 : i32 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :51 :21)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :51 :51) // Not a variable of known type: wallet
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :51 :10) // StatusCode(StatusCodes.Status201Created, wallet) (InvocationExpression)
return %6 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :51 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Bank.Controllers.RestController.Post$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :54 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :56 :26)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :56 :26)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :58 :24) // new WalletModel() (ObjectCreationExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :59 :3) // Not a variable of known type: wallet
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :59 :3) // wallet.id (SimpleMemberAccessExpression)
// Entity from another assembly: Guid
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :59 :15) // Guid.NewGuid() (InvocationExpression)
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :60 :3) // Not a variable of known type: wallet
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :60 :3) // wallet.balance (SimpleMemberAccessExpression)
%8 = constant 1000 : i32 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :60 :20)
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :61 :3) // Not a variable of known type: wallet
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :61 :3) // wallet.userId (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :61 :19) // Not a variable of known type: id
%12 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :62 :3) // Not a variable of known type: _walletCollection
%13 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :62 :31) // Not a variable of known type: wallet
%14 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :62 :3) // _walletCollection.InsertOne(wallet) (InvocationExpression)
%15 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :63 :10) // Not a variable of known type: wallet
return %15 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Bank\\Controllers\\RestController.cs" :63 :3)

^1: // ExitBlock
cbde.unreachable

}
