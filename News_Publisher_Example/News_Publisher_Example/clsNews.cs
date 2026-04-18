using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Publisher_Example
{
    public class clsNews
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public clsNews(string title, string content, DateTime publishDate)
        {
            this.Title = title;
            this.Content = content;
            this.PublishDate = publishDate;
        }
    }
}
