using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Publisher_Example
{
    public class clsSubscriber
    {
        public string Name { get; set; }
        public clsSubscriber(string name)
        {
            this.Name = name;
        }

        public void Subscribe(clsPublisher publisher)
        {
            publisher.NewsPublished += OnNewsPublished;
        }

        public void unSubscribe(clsPublisher publisher)
        {
            publisher.NewsPublished -= OnNewsPublished;
        }

        private void OnNewsPublished(object sender, clsNews news)
        {
            clsPublisher Publisher = (clsPublisher)sender;

            Console.WriteLine($"{Name} received news update from {Publisher.Name} about {news.Content}");
        }

    }
}
