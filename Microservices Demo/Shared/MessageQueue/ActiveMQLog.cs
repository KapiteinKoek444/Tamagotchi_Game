using Apache.NMS;
using Apache.NMS.ActiveMQ.Transactions;
using Apache.NMS.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class ActiveMQLog
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly ISession _session;

        public IMessageProducer messageProducer;
        public IMessageConsumer messageConsumer;

        public ActiveMQLog(string mqUrl)
        {
            _connectionFactory = new NMSConnectionFactory(mqUrl);

            var username = "admin";
            var password = "admin";

            IConnection connection = _connectionFactory.CreateConnection(username,password);
            connection.Start();
            _session = connection.CreateSession();

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

            messageConsumer.Listener += new MessageListener(MQLogger);
        }

        private void MQLogger(IMessage message)
        {
            ITextMessage objectMessage = message as ITextMessage;
            var result = objectMessage.Text;
        }
    }
}
