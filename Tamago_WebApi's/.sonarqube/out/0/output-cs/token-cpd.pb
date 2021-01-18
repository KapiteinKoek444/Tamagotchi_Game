Ñ
kC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ActiveMQ_Models\BuyItemModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
ActiveMQ_Models '
{ 
[ #
ExcludeFromCodeCoverage 
] 
public		 
class		 
BuyItemModel		 
{

 
public 
Guid	 
itemId 
{ 
get 
; 
set 
;  
}! "
public 
Guid	 
userId 
{ 
get 
; 
set 
;  
}! "
} 
} Æ
hC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ActiveMQ_Models\ItemModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
ActiveMQ_Models '
{ 
[		 #
ExcludeFromCodeCoverage		 
]		 
public

 
class

 
	ItemModel

 
{ 
public 
Guid	 
itemId 
; 
public 
Guid	 
userId 
; 
public 
double	 
price 
; 
public 
bool	 
confirmation 
; 
} 
} ê
oC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ActiveMQ_Models\RequestItemModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
ActiveMQ_Models '
{ 
[		 #
ExcludeFromCodeCoverage		 
]		 
public

 
class

 
RequestItemModel

 
{ 
public 
Guid	 
userId 
; 
public 
List	 
< 
Guid 
> 
Items 
; 
} 
} ÿ
wC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ActiveMQ_Models\RequestItemResponseModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
ActiveMQ_Models '
{		 
[

 #
ExcludeFromCodeCoverage

 
]

 
public 
class $
RequestItemResponseModel &
{ 
public 
Guid	 
userId 
; 
public 
List	 
< 
	FoodModel 
> 
items 
; 
} 
} ð
dC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ApiModels\AnimalModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
	ApiModels !
{ 
[ #
ExcludeFromCodeCoverage 
] 
public 

class 
AnimalModel 
{		 
[

 	
BsonId

	 
]

 
public 
Guid 
Id 
{ 
get 
; 
set !
;! "
}# $
public 
Guid 
UserId 
{ 
get  
;  !
set" %
;% &
}' (
public 
string 
Name 
{ 
get  
;  !
set" %
;% &
}' (
public 
float 
Food 
{ 
get 
;  
set! $
;$ %
}& '
public 
float 
Energy 
{ 
get !
;! "
set# &
;& '
}( )
public 
float 
	Happiness 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
int 

AnimalType 
{ 
get  #
;# $
set% (
;( )
}* +
} 
} ’
bC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ApiModels\FoodModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
	ApiModels !
{ 
[ #
ExcludeFromCodeCoverage 
] 
public 
class 
	FoodModel 
{		 
[

 
BsonId

 	
]

	 

public 
Guid	 
id 
{ 
get 
; 
set 
; 
} 
public 
string	 
name 
{ 
get 
; 
set 
;  
}! "
public 
string	 
category 
{ 
get 
; 
set  #
;# $
}% &
public 
double	 
price 
{ 
get 
; 
set  
;  !
}" #
public 
double	 
discount 
{ 
get 
; 
set  #
;# $
}% &
public 
double	 
foodVal 
{ 
get 
; 
set "
;" #
}$ %
public 
double	 
	energyVal 
{ 
get 
;  
set! $
;$ %
}& '
public 
double	 
happyVal 
{ 
get 
; 
set  #
;# $
}% &
} 
} ¿
gC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ApiModels\InventoryModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
	ApiModels !
{ 
[ #
ExcludeFromCodeCoverage 
] 
public		 
class		 
InventoryModel		 
{

 
[ 
BsonId 	
]	 

public 
Guid	 
id 
{ 
get 
; 
set 
; 
} 
public 
Guid	 
userId 
{ 
get 
; 
set 
;  
}! "
public 
List	 
< 
Guid 
> 
itemId 
{ 
get  
;  !
set" %
;% &
}' (
} 
} Š
bC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ApiModels\UserModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
	ApiModels !
{ 
[		 #
ExcludeFromCodeCoverage		 
]		 
public

 
class

 
	UserModel

 
{ 
[ 
BsonId 	
]	 

public 
Guid	 
Id 
{ 
get 
; 
set 
; 
} 
public 
string	 
Email 
{ 
get 
; 
set  
;  !
}" #
public 
string	 
Password 
{ 
get 
; 
set  #
;# $
}% &
} 
} Œ
dC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\ApiModels\WalletModel.cs
	namespace 	
Shared
 
. 
Shared 
. 
	ApiModels !
{ 
[		 #
ExcludeFromCodeCoverage		 
]		 
public

 
class

 
WalletModel

 
{ 
[ 
BsonId 	
]	 

public 
Guid	 
id 
{ 
get 
; 
set 
; 
} 
public 
Guid	 
userId 
{ 
get 
; 
set 
;  
}! "
public 
double	 
balance 
{ 
get 
; 
set "
;" #
}$ %
} 
} û6
nC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\Extensions\ActiveMQ\ActiveMQLog.cs
	namespace 	
Shared
 
. 

Extensions 
. 
ActiveMQ $
{ 
[ #
ExcludeFromCodeCoverage 
] 
public 

class 
ActiveMQLog 
: 
IActiveMqLog +
{ 
private 
readonly 
IConnectionFactory +
_connectionFactory, >
;> ?
private 
readonly 
ISession !
_session" *
;* +
private 
IMessageProducer !
messageProducer" 1
;1 2
private 
IMessageConsumer !
messageConsumer" 1
;1 2
private 
IConnection 
_connection '
;' (
private 
bool 
SessionActive "
;" #
public 
ActiveMQLog 
( 
string !
mqUrl" '
,' (
string) /
username0 8
,8 9
string: @
passwordA I
)I J
{ 	
if 
( 
mqUrl 
== 
$str 
|| 
username &
==' )
$str* ,
||- /
password0 8
==9 ;
$str< >
)> ?
return 
; 
if 
( 
mqUrl 
== 
null 
||  
username! )
==* ,
null- 1
||2 4
password5 =
==> @
nullA E
)E F
return 
; 
try   
{!! 
_connectionFactory"" "
=""# $
new""% ( 
NMSConnectionFactory"") =
(""= >
mqUrl""> C
)""C D
;""D E
_connection## 
=## 
_connectionFactory## 0
.##0 1
CreateConnection##1 A
(##A B
username##B J
,##J K
password##L T
)##T U
;##U V
_connection$$ 
.$$ 
Start$$ !
($$! "
)$$" #
;$$# $
_session%% 
=%% 
_connection%% &
.%%& '
CreateSession%%' 4
(%%4 5
)%%5 6
;%%6 7
SessionActive&& 
=&& 
true&&  $
;&&$ %
}'' 
catch(( 
((( 
	Exception(( 
e(( 
)(( 
{)) 
}++ 
}-- 	
public// 
void// 
ConnectSender// !
(//! "
string//" (
	queueName//) 2
)//2 3
{00 	
if11 
(11 
!11 
SessionActive11 
)11 
return22 
;22 
IDestination44 
destination44 $
=44% &
SessionUtil44' 2
.442 3
GetDestination443 A
(44A B
_session44B J
,44J K
	queueName44L U
)44U V
;44V W
messageProducer55 
=55 
_session55 &
.55& '
CreateProducer55' 5
(555 6
destination556 A
)55A B
;55B C
}66 	
public77 
void77 
ConnectListener77 #
(77# $
string77$ *
	queueName77+ 4
)774 5
{88 	
if99 
(99 
!99 
SessionActive99 
)99 
return:: 
;:: 
IDestination<< 
destination<< $
=<<% &
SessionUtil<<' 2
.<<2 3
GetDestination<<3 A
(<<A B
_session<<B J
,<<J K
	queueName<<L U
)<<U V
;<<V W
messageConsumer== 
=== 
_session== &
.==& '
CreateConsumer==' 5
(==5 6
destination==6 A
)==A B
;==B C
_connection>> 
.>> 
Start>> 
(>> 
)>> 
;>>  
}?? 	
publicAA 
ITextMessageAA #
ConvertObjectToIMessageAA 3
<AA3 4
TAA4 5
>AA5 6
(AA6 7
TAA7 8
typeAA9 =
)AA= >
{BB 	
varDD 
	xmlStringDD 
=DD 
XmlUtilDD #
.DD# $
	SerializeDD$ -
(DD- .
typeDD. 2
)DD2 3
;DD3 4
varEE 
messageEE 
=EE 
messageProducerEE )
.EE) *
CreateTextMessageEE* ;
(EE; <
	xmlStringEE< E
)EEE F
;EEF G
returnFF 
messageFF 
;FF 
}GG 	
publicHH 
THH #
ConvertIMessageToObjectHH )
<HH) *
THH* +
>HH+ ,
(HH, -
ITextMessageHH- 9
objectMessageHH: G
)HHG H
{II 	
varJJ 
objectStringJJ 
=JJ 
objectMessageJJ ,
.JJ, -
TextJJ- 1
;JJ1 2
TKK 
resultKK 
=KK 
(KK 
TKK 
)KK 
XmlUtilKK !
.KK! "
DeserializeKK" -
(KK- .
typeofKK. 4
(KK4 5
TKK5 6
)KK6 7
,KK7 8
objectStringKK9 E
)KKE F
;KKF G
returnLL 
resultLL 
;LL 
}MM 	
publicOO 
IMessageProducerOO 
GetMessageProducerOO  2
(OO2 3
)OO3 4
{PP 	
ifQQ 
(QQ 
!QQ 
SessionActiveQQ 
)QQ 
returnRR 
nullRR 
;RR 
returnTT 
messageProducerTT "
;TT" #
}UU 	
publicVV 
IMessageConsumerVV 
GetMessageConsumerVV  2
(VV2 3
)VV3 4
{WW 	
ifXX 
(XX 
!XX 
SessionActiveXX 
)XX 
returnYY 
nullYY 
;YY 
return[[ 
messageConsumer[[ "
;[[" #
}\\ 	
public^^ 
bool^^ 
IsSesionActive^^ "
(^^" #
)^^# $
{__ 	
return`` 
SessionActive``  
;``  !
}aa 	
publiccc 
voidcc 
CloseSessioncc  
(cc  !
)cc! "
{dd 	
ifee 
(ee 
!ee 
SessionActiveee 
)ee 
returnff 
;ff 
_sessionhh 
.hh 
Closehh 
(hh 
)hh 
;hh 
_connectionii 
.ii 
Stopii 
(ii 
)ii 
;ii 
SessionActivejj 
=jj 
falsejj !
;jj! "
}kk 	
}nn 
}oo ö

oC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\Extensions\ActiveMQ\IActiveMQLog.cs
	namespace 	
Shared
 
. 

Extensions 
. 
ActiveMQ $
{ 
public 

	interface 
IActiveMqLog !
{ 
void		 
ConnectListener		 
(		 
string		 #
	queueName		$ -
)		- .
;		. /
void

 
ConnectSender

 
(

 
string

 !
	queueName

" +
)

+ ,
;

, -
void 
CloseSession 
( 
) 
; 
bool 
IsSesionActive 
( 
) 
; 
IMessageConsumer 
GetMessageConsumer +
(+ ,
), -
;- .
IMessageProducer 
GetMessageProducer +
(+ ,
), -
;- .
ITextMessage #
ConvertObjectToIMessage ,
<, -
T- .
>. /
(/ 0
T0 1
type2 6
)6 7
;7 8
T 	#
ConvertIMessageToObject
 !
<! "
T" #
># $
($ %
ITextMessage% 1
objectMessage2 ?
)? @
;@ A
} 
} ©
uC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\Extensions\Consul\ConfigurationSetting.cs
	namespace 	
Shared
 
. 

Extensions 
. 
Consul "
{ 
[ #
ExcludeFromCodeCoverage 
] 
public		 

class		  
ConfigurationSetting		 %
{

 
public 
string 
ServiceName !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
string 
ServiceHost !
{" #
get$ '
;' (
set) ,
;, -
}. /
public 
int 
ServicePort 
{  
get! $
;$ %
set& )
;) *
}+ ,
public 
string 
ConsulAddress #
{$ %
get& )
;) *
set+ .
;. /
}0 1
} 
} ¨"
|C:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\Extensions\Consul\ServiceRegistryAppExtension.cs
	namespace

 	
UserManagement


 
.

 
Config

 
{ 
[ #
ExcludeFromCodeCoverage 
] 
public 

static 
class '
ServiceRegistryAppExtension 3
{ 
public 
static 
IServiceCollection (
AddConsulConfig) 8
(8 9
this9 =
IServiceCollection> P
servicesQ Y
,Y Z 
ConfigurationSetting[ o!
configurationSetting	p „
)
„ …
{ 	
services 
. 
AddSingleton !
<! "
IConsulClient" /
,/ 0
ConsulClient1 =
>= >
(> ?
p? @
=>A C
newD G
ConsulClientH T
(T U
consulConfigU a
=>b d
{ 
consulConfig 
. 
Address $
=% &
new' *
Uri+ .
(. / 
configurationSetting/ C
.C D
ConsulAddressD Q
)Q R
;R S
} 
) 
) 
; 
return 
services 
; 
} 	
public 
static 
IApplicationBuilder )
	UseConsul* 3
(3 4
this4 8
IApplicationBuilder9 L
appM P
,P Q 
ConfigurationSettingR f 
configurationSettingg {
){ |
{ 	
var 
consulClient 
= 
app "
." #
ApplicationServices# 6
.6 7
GetRequiredService7 I
<I J
IConsulClientJ W
>W X
(X Y
)Y Z
;Z [
var 
logger 
= 
app 
. 
ApplicationServices 0
.0 1
GetRequiredService1 C
<C D
ILoggerFactoryD R
>R S
(S T
)T U
.U V
CreateLoggerV b
(b c
$strc r
)r s
;s t
var 
lifetime 
= 
app 
. 
ApplicationServices 2
.2 3
GetRequiredService3 E
<E F 
IApplicationLifetimeF Z
>Z [
([ \
)\ ]
;] ^
var 
registration 
= 
new "$
AgentServiceRegistration# ;
(; <
)< =
{   
ID!! 
=!!  
configurationSetting!! )
.!!) *
ServiceName!!* 5
,!!5 6
Name## 
=##  
configurationSetting## +
.##+ ,
ServiceName##, 7
,##7 8
Address$$ 
=$$  
configurationSetting$$ .
.$$. /
ServiceHost$$/ :
,$$: ;
Port%% 
=%%  
configurationSetting%% +
.%%+ ,
ServicePort%%, 7
}'' 
;'' 
logger)) 
.)) 
LogInformation)) !
())! "
$str))" ;
))); <
;))< =
consulClient** 
.** 
Agent** 
.** 
ServiceDeregister** 0
(**0 1
registration**1 =
.**= >
ID**> @
)**@ A
.**A B
ConfigureAwait**B P
(**P Q
true**Q U
)**U V
;**V W
consulClient++ 
.++ 
Agent++ 
.++ 
ServiceRegister++ .
(++. /
registration++/ ;
)++; <
.++< =
ConfigureAwait++= K
(++K L
true++L P
)++P Q
;++Q R
lifetime-- 
.-- 
ApplicationStopping-- (
.--( )
Register--) 1
(--1 2
(--2 3
)--3 4
=>--5 7
{.. 
logger// 
.// 
LogInformation// %
(//% &
$str//& @
)//@ A
;//A B
}00 
)00 
;00 
return22 
app22 
;22 
}33 	
}44 
}55 ¤
nC:\Users\Pouki\Documents\#Rep_C\#Fontys_S3\S3_Tamago_WebApi's\Shared\Shared\Extensions\Consul\StartupConfig.cs
	namespace 	
Shared
 
. 

Extensions 
. 
Consul "
{ 
[ #
ExcludeFromCodeCoverage 
] 
public		 

static		 
class		 
StartupConfig		 %
{

 
public 
static  
ConfigurationSetting *!
RegisterConfiguration+ @
(@ A
thisA E
IServiceCollectionF X
servicesY a
,a b
IConfigurationc q
configurationr 
)	 €
{ 	
services 
. 
	Configure 
<  
ConfigurationSetting 3
>3 4
(4 5
configuration5 B
.B C

GetSectionC M
(M N
$strN ]
)] ^
)^ _
;_ `
var 
serviceProvider 
=  !
services" *
.* + 
BuildServiceProvider+ ?
(? @
)@ A
;A B
var 
iop 
= 
serviceProvider %
.% &

GetService& 0
<0 1
IOptions1 9
<9 : 
ConfigurationSetting: N
>N O
>O P
(P Q
)Q R
;R S
return 
iop 
. 
Value 
; 
} 	
} 
} 