using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shared.Extensions.ActiveMQ;

namespace SharedTests
{
    [TestClass]
    public class ActiveMQTests
    {
        private ActiveMQLog activeMq;
        private readonly string mqUrl = "tcp://86.91.4.211:61616";
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
    }
}
