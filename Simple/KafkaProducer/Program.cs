using System;

namespace KafkaProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Kafka Producer Started. {Environment.NewLine}Type message and hit return to send{Environment.NewLine}");

            var producer = new Producer();

            while (true)
            {
                Console.Write(">");
                producer.Send(Console.ReadLine());
            }
        }
    }
}
