using System;
using System.Collections.Generic;
using System.Text;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;

namespace KafkaProducer
{
    public class Producer : IProducer
    {
        readonly Producer<Null, string> _producer;
        public Producer()
        {
            var config = new Dictionary<string, object>
            {
                {"bootstrap.servers", "localhost:9092"}
            };

            
            _producer = new Producer<Null, string>(config, null, new StringSerializer(Encoding.UTF8));
        }
        public void Send(string message)
        {

                var dr = _producer.ProduceAsync("si-top", null, message).Result;       
        }
    }
}