func @_Shared.Extensions.ActiveMQ.ActiveMQLog.ConnectSender$string$(none) -> () loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :46 :8) {
^entry (%_queueName : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :46 :34)
cbde.store %_queueName, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :46 :34)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :48 :16) // Not a variable of known type: SessionActive
%2 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :48 :15) // !SessionActive (LogicalNotExpression)
cond_br %2, ^1, ^2 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :48 :15)

^1: // JumpBlock
return loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :49 :16)

^2: // SimpleBlock
// Entity from another assembly: SessionUtil
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :51 :66) // Not a variable of known type: _session
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :51 :76) // Not a variable of known type: queueName
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :51 :39) // SessionUtil.GetDestination(_session, queueName) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :52 :30) // Not a variable of known type: _session
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :52 :54) // Not a variable of known type: destination
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :52 :30) // _session.CreateProducer(destination) (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
func @_Shared.Extensions.ActiveMQ.ActiveMQLog.ConnectListener$string$(none) -> () loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :54 :8) {
^entry (%_queueName : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :54 :36)
cbde.store %_queueName, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :54 :36)
br ^0

^0: // BinaryBranchBlock
%1 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :56 :17) // Not a variable of known type: SessionActive
%2 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :56 :16) // !SessionActive (LogicalNotExpression)
cond_br %2, ^1, ^2 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :56 :16)

^1: // JumpBlock
return loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :57 :16)

^2: // SimpleBlock
// Entity from another assembly: SessionUtil
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :59 :66) // Not a variable of known type: _session
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :59 :76) // Not a variable of known type: queueName
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :59 :39) // SessionUtil.GetDestination(_session, queueName) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :60 :30) // Not a variable of known type: _session
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :60 :54) // Not a variable of known type: destination
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :60 :30) // _session.CreateConsumer(destination) (InvocationExpression)
%10 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :61 :12) // Not a variable of known type: _connection
%11 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :61 :12) // _connection.Start() (InvocationExpression)
br ^3

^3: // ExitBlock
return

}
func @_Shared.Extensions.ActiveMQ.ActiveMQLog.ConvertObjectToIMessage$T$$T$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :64 :8) {
^entry (%_type : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :64 :55)
cbde.store %_type, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :64 :55)
br ^0

^0: // JumpBlock
// Entity from another assembly: XmlUtil
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :67 :46) // Not a variable of known type: type
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :67 :28) // XmlUtil.Serialize(type) (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :68 :26) // Not a variable of known type: messageProducer
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :68 :60) // Not a variable of known type: xmlString
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :68 :26) // messageProducer.CreateTextMessage(xmlString) (InvocationExpression)
%8 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :69 :19) // Not a variable of known type: message
return %8 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :69 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_Shared.Extensions.ActiveMQ.ActiveMQLog.ConvertIMessageToObject$T$$Apache.NMS.ITextMessage$(none) -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :71 :8) {
^entry (%_objectMessage : none):
%0 = cbde.alloca none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :71 :45)
cbde.store %_objectMessage, %0 : memref<none> loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :71 :45)
br ^0

^0: // JumpBlock
%1 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :73 :31) // Not a variable of known type: objectMessage
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :73 :31) // objectMessage.Text (SimpleMemberAccessExpression)
// Entity from another assembly: XmlUtil
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :74 :46) // typeof(T) (TypeOfExpression)
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :74 :57) // Not a variable of known type: objectString
%6 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :74 :26) // XmlUtil.Deserialize(typeof(T), objectString) (InvocationExpression)
%7 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :74 :23) // (T)XmlUtil.Deserialize(typeof(T), objectString) (CastExpression)
%9 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :75 :19) // Not a variable of known type: result
return %9 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :75 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_Shared.Extensions.ActiveMQ.ActiveMQLog.GetMessageProducer$$() -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :78 :8) {
^entry :
br ^0

^0: // BinaryBranchBlock
%0 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :80 :17) // Not a variable of known type: SessionActive
%1 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :80 :16) // !SessionActive (LogicalNotExpression)
cond_br %1, ^1, ^2 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :80 :16)

^1: // JumpBlock
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :81 :23) // null (NullLiteralExpression)
return %2 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :81 :16)

^2: // JumpBlock
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :83 :19) // Not a variable of known type: messageProducer
return %3 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :83 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_Shared.Extensions.ActiveMQ.ActiveMQLog.GetMessageConsumer$$() -> none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :85 :8) {
^entry :
br ^0

^0: // BinaryBranchBlock
%0 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :87 :17) // Not a variable of known type: SessionActive
%1 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :87 :16) // !SessionActive (LogicalNotExpression)
cond_br %1, ^1, ^2 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :87 :16)

^1: // JumpBlock
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :88 :23) // null (NullLiteralExpression)
return %2 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :88 :16)

^2: // JumpBlock
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :90 :19) // Not a variable of known type: messageConsumer
return %3 : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :90 :12)

^3: // ExitBlock
cbde.unreachable

}
func @_Shared.Extensions.ActiveMQ.ActiveMQLog.IsSesionActive$$() -> i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :93 :8) {
^entry :
br ^0

^0: // JumpBlock
%0 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :95 :19) // Not a variable of known type: SessionActive
return %0 : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :95 :12)

^1: // ExitBlock
cbde.unreachable

}
func @_Shared.Extensions.ActiveMQ.ActiveMQLog.CloseSession$$() -> () loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :98 :8) {
^entry :
br ^0

^0: // BinaryBranchBlock
%0 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :100 :17) // Not a variable of known type: SessionActive
%1 = cbde.unknown : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :100 :16) // !SessionActive (LogicalNotExpression)
cond_br %1, ^1, ^2 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :100 :16)

^1: // JumpBlock
return loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :101 :16)

^2: // SimpleBlock
%2 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :103 :12) // Not a variable of known type: _session
%3 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :103 :12) // _session.Close() (InvocationExpression)
%4 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :104 :12) // Not a variable of known type: _connection
%5 = cbde.unknown : none loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :104 :12) // _connection.Stop() (InvocationExpression)
%6 = constant 0 : i1 loc("C:\\Users\\Pouki\\Documents\\#Rep_C\\#Fontys_S3\\S3_Tamago_WebApi's\\Shared\\Shared\\Extensions\\ActiveMQ\\ActiveMQLog.cs" :105 :28) // false
br ^3

^3: // ExitBlock
return

}
