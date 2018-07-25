using System;

namespace KafkaConsumer
{
    public interface IConsumer
    {
        void Listen(Action<string> message);
    }
}