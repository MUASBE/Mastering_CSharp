using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Publisher_Example
{
    public class clsPublisher
    {
        public string Name { get; set; }
        public List<clsNews> PublishedNews { get; set; }
        public clsPublisher(string name)
        {
            this.Name = name;
            this.PublishedNews = new List<clsNews>();
        }

        public event EventHandler<clsNews> NewsPublished;



        public void PublishNews(clsNews news)
        {
            PublishedNews.Add(news);
            Console.WriteLine($"\nNews '{news.Title}' published by {Name} on {news.PublishDate}\n");
            NewsPublished.Invoke(this, news);
        }
    }
}
