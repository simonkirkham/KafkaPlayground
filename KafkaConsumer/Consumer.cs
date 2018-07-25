using System;
using System.Collections.Generic;
using System.Text;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;

namespace KafkaConsumer
{
    public class Consumer : IConsumer
    {
        public void Listen(Action<string> message)
        {
            var config = new Dictionary<string, object>
            {
                {"group.id", "consumer"},
                {"bootstrap.servers", "localhost:9092"},
                {"enable.auto.commit", "false"},
                {"auto.offset.reset", "smallest" }
            };

            using (var consumer = new Consumer<Null, string>(config, null, new StringDeserializer(Encoding.UTF8)))
            {
                consumer.Subscribe("si-top");

                consumer.OnMessage += (_, msg) => { message(msg.Value); };

                while (true)
                {
                    consumer.Poll(100);
                }
            }

        }
    }
}