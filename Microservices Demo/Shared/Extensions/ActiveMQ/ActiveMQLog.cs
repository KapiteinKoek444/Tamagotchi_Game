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
        private bool SessionActive;

        public ActiveMQLog(string mqUrl, string username, string password)
        {
            if(mqUrl == "" || username == "" || password == "")
                return;

            if (mqUrl == null || username == null || password == null)
                return;
            try
            {
                _connectionFactory = new NMSConnectionFactory(mqUrl);
                _connection = _connectionFactory.CreateConnection(username, password);
                _connection.Start();
                _session = _connection.CreateSession();
                SessionActive = true;
            }
            catch (Exception e)
            {

            }

        }

        public void ConnectSender(string queueName)
        {
            if(!SessionActive)
                return;

            IDestination destination = SessionUtil.GetDestination(_session, queueName);
            messageProducer = _session.CreateProducer(destination);
        }
        public void ConnectListener(string queueName)
        {
            if (!SessionActive)
                return;

            IDestination destination = SessionUtil.GetDestination(_session, queueName);
            messageConsumer = _session.CreateConsumer(destination);
            _connection.Start();
        }

        public ITextMessage ConvertObjectToIMessage<T>(T type)
        {

            var xmlString = XmlUtil.Serialize(type);
            var message = messageProducer.CreateTextMessage(xmlString);
            return message;
        }
        public  T ConvertIMessageToObject<T>(ITextMessage objectMessage)
        {
            var objectString = objectMessage.Text;
            T result = (T)XmlUtil.Deserialize(typeof(T), objectString);
            return result;
        }

        public IMessageProducer GetMessageProducer()
        {
            if (!SessionActive)
                return null;

            return messageProducer;
        }
        public IMessageConsumer GetMessageConsumer()
        {
            if (!SessionActive)
                return null;

            return messageConsumer;
        }

        public bool IsSesionActive()
        {
            return SessionActive;
        }

        public void CloseSession()
        {
            if (!SessionActive)
                return;

            _session.Close();
            _connection.Stop();
            SessionActive = false;
        }


    }
}
