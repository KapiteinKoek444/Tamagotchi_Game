func @_Tamago_Shop.Controllers.RestController.Index$$() -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :22 :2) {
^entry :
br ^0

^0: // JumpBlock
// Entity from another assembly: View
%0 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :24 :10) // View() (InvocationExpression)
return %0 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :24 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Shop.Controllers.RestController.Get$$() -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :27 :2) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :30 :14) // Not a variable of known type: _foodCollection
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :30 :35) // Builders<FoodModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :30 :35) // Builders<FoodModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :30 :35) // Builders<FoodModel>.Filter.Empty (SimpleMemberAccessExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :30 :14) // _foodCollection.Find(Builders<FoodModel>.Filter.Empty) (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :30 :14) // _foodCollection.Find(Builders<FoodModel>.Filter.Empty).ToList() (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :31 :10) // Not a variable of known type: data
return %7 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :31 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Shop.Controllers.RestController.Get$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :34 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :35 :23)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :35 :23)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :37 :16) // Builders<FoodModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :37 :16) // Builders<FoodModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :37 :46) // "id" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :37 :52) // Not a variable of known type: id
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :37 :16) // Builders<FoodModel>.Filter.Eq("id", id) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :38 :14) // Not a variable of known type: _foodCollection
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :38 :35) // Not a variable of known type: filter
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :38 :14) // _foodCollection.Find(filter) (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :38 :14) // _foodCollection.Find(filter).FirstOrDefault() (InvocationExpression)
%12 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :39 :10) // Not a variable of known type: data
return %12 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :39 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Shop.Controllers.RestController.Remove$System.Guid$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :42 :2) {
^entry (%_id : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :44 :26)
cbde.store %_id, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :44 :26)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :46 :16) // Builders<FoodModel> (GenericName)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :46 :16) // Builders<FoodModel>.Filter (SimpleMemberAccessExpression)
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :46 :46) // "id" (StringLiteralExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :46 :52) // Not a variable of known type: id
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :46 :16) // Builders<FoodModel>.Filter.Eq("id", id) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :47 :14) // Not a variable of known type: _foodCollection
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :47 :47) // Not a variable of known type: filter
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :47 :14) // _foodCollection.FindOneAndDelete(filter) (InvocationExpression)
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :48 :10) // Not a variable of known type: data
return %11 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :48 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Shop.Controllers.RestController.Post$Shared.Shared.ApiModels.FoodModel$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :51 :2) {
^entry (%_food : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :53 :28)
cbde.store %_food, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :53 :28)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :55 :3) // Not a variable of known type: _foodCollection
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :55 :29) // Not a variable of known type: food
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :55 :3) // _foodCollection.InsertOne(food) (InvocationExpression)
// Entity from another assembly: StatusCode
// Entity from another assembly: StatusCodes
%4 = constant 201 : i32 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :56 :21)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :56 :51) // Not a variable of known type: food
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :56 :10) // StatusCode(StatusCodes.Status201Created, food) (InvocationExpression)
return %6 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :56 :3)

^1: // ExitBlock
cbde.unreachable

}
func @_Tamago_Shop.Controllers.RestController.PushFood$$() -> () loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :59 :2) {
^entry :
br ^0

^0: // SimpleBlock
%0 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :62 :20) // new FoodModel() (ObjectCreationExpression)
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :63 :3) // Not a variable of known type: food
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :63 :3) // food.id (SimpleMemberAccessExpression)
// Entity from another assembly: Guid
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :63 :13) // Guid.NewGuid() (InvocationExpression)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :64 :3) // Not a variable of known type: food
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :64 :3) // food.name (SimpleMemberAccessExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :64 :15) // "Red-cow" (StringLiteralExpression)
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :65 :3) // Not a variable of known type: food
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :65 :3) // food.category (SimpleMemberAccessExpression)
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :65 :19) // "soda" (StringLiteralExpression)
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :66 :3) // Not a variable of known type: food
%12 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :66 :3) // food.price (SimpleMemberAccessExpression)
%13 = constant unit loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :66 :16) // 1.5 (NumericLiteralExpression)
%14 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :67 :3) // Not a variable of known type: food
%15 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :67 :3) // food.discount (SimpleMemberAccessExpression)
%16 = constant unit loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :67 :19) // 0.0 (NumericLiteralExpression)
%17 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :69 :3) // Not a variable of known type: food
%18 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :69 :3) // food.foodVal (SimpleMemberAccessExpression)
%19 = constant 3 : i32 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :69 :18)
%20 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :70 :3) // Not a variable of known type: food
%21 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :70 :3) // food.energyVal (SimpleMemberAccessExpression)
%22 = constant 8 : i32 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :70 :20)
%23 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :71 :3) // Not a variable of known type: food
%24 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :71 :3) // food.happyVal (SimpleMemberAccessExpression)
%25 = constant 2 : i32 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :71 :19)
// Skipped because MethodDeclarationSyntax or ClassDeclarationSyntax or NamespaceDeclarationSyntax: Post
%26 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :73 :8) // Not a variable of known type: food
%27 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Tamago_Shop\\Controllers\\RestController.cs" :73 :3) // Post(food) (InvocationExpression)
br ^1

^1: // ExitBlock
return

}
