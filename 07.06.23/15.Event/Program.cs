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

            StandardPublisher standardPublisher = new StandardPublisher();
            StandardSubscriber standardSubscriber = new StandardSubscriber(standardPublisher);
            standardSubscriber.UseExtention(standardPublisher);
            standardPublisher.TryEvent();
        }
    }
}