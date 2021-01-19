using System;
using Apache.NMS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Extensions.ActiveMQ;
using Shared.Shared.ApiModels;

namespace SharedTests
{
    [TestClass]
    public class ActiveMQTests
    {
        private ActiveMQLog activeMq;
        private readonly string mqUrl = "tcp://82.169.80.49:61616";
        private readonly string username = "admin";
        private readonly string password = "admin";

        [TestMethod]
        public void ActiveMQCanConnectToServerWithInput()
        {
            activeMq = new ActiveMQLog(mqUrl,username,password);
            Assert.IsTrue(activeMq.IsSesionActive());
        }

        [TestMethod]
        public void ActiveMQCannotConnectToServerWithEmptyInput()
        {
            activeMq = new ActiveMQLog("", "", "");
            Assert.IsFalse(activeMq.IsSesionActive());
        }

        [TestMethod]
        public void ActiveMQCannotConnectToServerWithNullInput()
        {
            activeMq = new ActiveMQLog(null, null, null);
            Assert.IsFalse(activeMq.IsSesionActive());
        }


        [TestMethod]
        public void CannotGetProducerWithEmptyConnectionInput()
        {
            activeMq = new ActiveMQLog("", "", "");
            activeMq.ConnectSender("");
            var result = activeMq.GetMessageProducer();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void CannotGetConsumerWithEmptyConnectionInput()
        {
            activeMq = new ActiveMQLog("", "", "");
            activeMq.ConnectListener("");
            var result = activeMq.GetMessageConsumer();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void CanGetProducerWithConnectionInput()
        {
            activeMq = new ActiveMQLog(mqUrl, username, password); ;
            activeMq.ConnectSender("Clock.GetUserTimeStamp.queue");
            var result = activeMq.GetMessageProducer();
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CanGetConsumerWithConnectionInput()
        {
            activeMq = new ActiveMQLog(mqUrl, username, password);
            activeMq.ConnectListener("Clock.GetUserTimeStampResponse.queue");
            var result = activeMq.GetMessageConsumer();
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ConvertObjectToIMessageTest()
        {
            activeMq = new ActiveMQLog(mqUrl, username, password);
            UserModel model = new UserModel
            {
                Id = Guid.NewGuid(),
                Email = "test",
                Password = "test",
            };
            activeMq.ConnectSender("Clock.GetUserTimeStamp.queue");
            IMessage result = activeMq.ConvertObjectToIMessage<UserModel>(model);

            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ConvertIMessageToObjectTest()
        {
            activeMq = new ActiveMQLog(mqUrl, username, password);
            UserModel model = new UserModel
            {
                Id = Guid.NewGuid(),
                Email = "test",
                Password = "test",
            };
            activeMq.ConnectSender("Clock.GetUserTimeStamp.queue");
            ITextMessage Textmessage = activeMq.ConvertObjectToIMessage<UserModel>(model) as ITextMessage;
            UserModel result = activeMq.ConvertIMessageToObject<UserModel>(Textmessage);

            Assert.IsNotNull(result);
        }
    }
}
