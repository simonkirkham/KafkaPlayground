using System;

namespace KafkaConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kafka Consumer Started.");
            var consumer = new Consumer();
            consumer.Listen(Console.WriteLine);
        }
    }
}
