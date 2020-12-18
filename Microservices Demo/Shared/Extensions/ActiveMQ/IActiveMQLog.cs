﻿using Apache.NMS;
using System;

namespace Shared.Extensions.ActiveMQ
{
    public interface IActiveMqLog
    {
        void ConnectListener(string queueName);
        void ConnectSender(string queueName);
        void CloseSession();

        bool IsSesionActive();

        IMessageConsumer GetMessageConsumer();
        IMessageProducer GetMessageProducer();
        ITextMessage ConvertObjectToIMessage<T>(T type);
        T ConvertIMessageToObject<T>(ITextMessage objectMessage);
    }
}