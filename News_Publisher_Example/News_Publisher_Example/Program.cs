using News_Publisher_Example;
using System;

class Program
{
    static void Main()
    {
        clsPublisher publisher = new clsPublisher("Global News");

        clsSubscriber subscriber1 = new clsSubscriber("Alice");
        clsSubscriber subscriber2 = new clsSubscriber("Bob");
        clsSubscriber subscriber3 = new clsSubscriber("Musab");
        clsSubscriber subscriber4 = new clsSubscriber("Ali");

        subscriber1.Subscribe(publisher);
        subscriber2.Subscribe(publisher);
        subscriber3.Subscribe(publisher);
        subscriber4.Subscribe(publisher);


        clsNews news1 = new clsNews("Breaking News", "Danak fever is still occuring in Sudan!", DateTime.Now);

        publisher.PublishNews(news1);

        news1.Content = "University of khartoum have Closed all internal an external centers, and started continuing physical education!";
        news1.PublishDate = DateTime.Now.AddDays(5);

        subscriber1.unSubscribe(publisher);

        publisher.PublishNews(news1);


    }
}
