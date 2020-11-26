using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Transactions;
using Apache.NMS.Util;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Shared.Extensions.ActiveMQ
{
    public class ActiveMQLog : IActiveMqLog
    {

        private readonly IConnectionFactory _connectionFactory;
        private readonly ISession _session;

        private  IMessageProducer messageProducer;
        private  IMessageConsumer messageConsumer;
        private IConnection _connection;
        private bool SesionActive;

        public ActiveMQLog(string mqUrl, string username, string password)
        {
            if(mqUrl == "" || username == "" || password == "")
                return;

            if (mqUrl == null || username == null || password == null)
                return;

            _connectionFactory = new NMSConnectionFactory(mqUrl);
            _connection = _connectionFactory.CreateConnection(username, password);
            _connection.Start();
            _session = _connection.CreateSession();
            SesionActive = true;
        }

        public void ConnectSender(string queueName)
        {
            if(!SesionActive)
                return;

            IDestination destination = SessionUtil.GetDestination(_session, queueName);
            messageProducer = _session.CreateProducer(destination);
        }
        public void ConnectListener(string queueName)
        {
            if (!SesionActive)
                return;

            IDestination destination = SessionUtil.GetDestination(_session, queueName);
            messageConsumer = _session.CreateConsumer(destination);
        }

        public ITextMessage ConvertObjectToIMessage(Type type)
        {

            var jsonString = JsonConvert.SerializeObject(type);
            var messege = messageProducer.CreateTextMessage(jsonString);
            return messege;
        }
        public  T ConvertIMessageToObject<T>(ITextMessage objectMessage)
        {

            var objectString = objectMessage.Text;
            var result = JsonConvert.DeserializeObject<T>(objectString);
            return result;
        }
        public IMessageProducer GetMessageProducer()
        {
            if (!SesionActive)
                return null;

            return messageProducer;
        }
        public IMessageConsumer GetMessageConsumer()
        {
            if (!SesionActive)
                return null;

            return messageConsumer;
        }

        public bool IsSesionActive()
        {
            return SesionActive;
        }

        public void CloseSession()
        {
            if (!SesionActive)
                return;

            _session.Close();
            _connection.Stop();
            SesionActive = false;
        }


    }
}
