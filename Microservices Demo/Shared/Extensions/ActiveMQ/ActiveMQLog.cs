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
    public class ActiveMQLog : IActiveMQLog
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly ISession _session;

        private  IMessageProducer messageProducer;
        private  IMessageConsumer messageConsumer;
        private IConnection connection;

        public ActiveMQLog(string mqUrl, string username, string password)
        {
            _connectionFactory = new NMSConnectionFactory(mqUrl);

            try
            {
            connection = _connectionFactory.CreateConnection(username, password);
            connection.Start();
            _session = connection.CreateSession();

            }
            catch (Exception)
            {

                throw;
            }

        }

        public void ConnectSender(string queueName)
        {
            IDestination destination = SessionUtil.GetDestination(_session, queueName);
            messageProducer = _session.CreateProducer(destination);
        }
        public void ConnectListener(string queueName)
        {
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
            return messageProducer;
        }
        public IMessageConsumer GetMessageConsumer()
        {
            return messageConsumer;
        }

        public void CloseSession()
        {
            _session.Close();
            connection.Stop();
        }


    }
}
