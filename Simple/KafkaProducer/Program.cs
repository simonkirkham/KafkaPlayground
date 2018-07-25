using System;

namespace KafkaProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            var producer = new Producer();

            while (true)
            {
                producer.Send(Console.ReadLine());
            }
        }
    }
}
