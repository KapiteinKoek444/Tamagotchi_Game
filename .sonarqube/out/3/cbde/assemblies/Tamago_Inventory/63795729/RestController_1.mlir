func @_Tamago_Inventory.Controllers.RestController.Get$$() -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :22 :2) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :25 :14) // Not a variable of known type: _inventoryCollection
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :25 :40) // Builders<InventoryModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :25 :40) // Builders<InventoryModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :25 :40) // Builders<InventoryModel>.Filter.Empty (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :25 :14) // _inventoryCollection.Find(Builders<InventoryModel>.Filter.Empty) (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :25 :14) // _inventoryCollection.Find(Builders<InventoryModel>.Filter.Empty).ToList() (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :26 :10) // Not a variable of known type: data
return %7 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :26 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Inventory.Controllers.RestController.Get$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :29 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :30 :28)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :30 :28)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :32 :16) // Builders<InventoryModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :32 :16) // Builders<InventoryModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :32 :51) // "userId" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :32 :61) // Not a variable of known type: id
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :32 :16) // Builders<InventoryModel>.Filter.Eq("userId", id) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :33 :14) // Not a variable of known type: _inventoryCollection
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :33 :40) // Not a variable of known type: filter
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :33 :14) // _inventoryCollection.Find(filter) (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :33 :14) // _inventoryCollection.Find(filter).FirstOrDefault() (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :34 :10) // Not a variable of known type: data
return %12 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :34 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Inventory.Controllers.RestController.Remove$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :37 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :39 :31)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :39 :31)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :41 :16) // Builders<InventoryModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :41 :16) // Builders<InventoryModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :41 :51) // "userId" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :41 :61) // Not a variable of known type: id
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :41 :16) // Builders<InventoryModel>.Filter.Eq("userId", id) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :42 :14) // Not a variable of known type: _inventoryCollection
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :42 :52) // Not a variable of known type: filter
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :42 :14) // _inventoryCollection.FindOneAndDelete(filter) (InvocationExpression)
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :43 :10) // Not a variable of known type: data
return %11 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :43 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Inventory.Controllers.RestController.Post$Shared.Shared.ApiModels.InventoryModel$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :46 :2) {
^entry (%_inv : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :48 :28)
cbde.store %_inv, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :48 :28)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :50 :3) // Not a variable of known type: _inventoryCollection
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :50 :34) // Not a variable of known type: inv
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :50 :3) // _inventoryCollection.InsertOne(inv) (InvocationExpression)
// Entity from another assembly: StatusCode
// Entity from another assembly: StatusCodes
%4 = constant 201 : i32 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :51 :21)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :51 :51) // Not a variable of known type: inv
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :51 :10) // StatusCode(StatusCodes.Status201Created, inv) (InvocationExpression)
return %6 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :51 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Inventory.Controllers.RestController.Post$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :54 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :56 :29)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :56 :29)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :58 :24) // new InventoryModel() (ObjectCreationExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :59 :3) // Not a variable of known type: inv
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :59 :3) // inv.id (SimpleMemberAccessExpression)
// Entity from another assembly: Guid
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :59 :12) // Guid.NewGuid() (InvocationExpression)
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :60 :3) // Not a variable of known type: inv
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :60 :3) // inv.userId (SimpleMemberAccessExpression)
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :60 :16) // Not a variable of known type: id
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :61 :3) // Not a variable of known type: inv
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :61 :3) // inv.itemId (SimpleMemberAccessExpression)
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :61 :16) // new List<Guid>() (ObjectCreationExpression)
%12 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :62 :3) // Not a variable of known type: _inventoryCollection
%13 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :62 :34) // Not a variable of known type: inv
%14 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :62 :3) // _inventoryCollection.InsertOne(inv) (InvocationExpression)
%15 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :63 :10) // Not a variable of known type: inv
return %15 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Inventory\\Controllers\\RestController.cs" :63 :3)

^1: // ExitBlock
cbde.unreachable

}
