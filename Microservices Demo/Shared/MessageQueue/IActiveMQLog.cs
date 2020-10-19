using Apache.NMS;

namespace Shared
{
    public interface IActiveMQLog
    {
        void ConnectListener(string queueName);
        void ConnectSender(string queueName);
        IMessageConsumer GetMessageConsumer();
        IMessageProducer GetMessageProducer();
    }
}