namespace Event15
{
    class Program
    {
        static void Main()
        {
            CustomPublisher customPublisher = new CustomPublisher();
            Subscriber subscriber = new Subscriber();

            subscriber.D(customPublisher);
            customPublisher.TryEvent();
        }
    }
}