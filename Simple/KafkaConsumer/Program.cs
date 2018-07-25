using System;

namespace KafkaConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            var consumer = new Consumer();
            consumer.Listen(Console.WriteLine);
        }
    }
}
