namespace KafkaProducer
{
    public interface IProducer
    {
        void Send(string message);
    }
}