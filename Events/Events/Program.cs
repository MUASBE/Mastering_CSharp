using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {

            clsYoutubeChannel channel = new clsYoutubeChannel("ELzero web school");
            clsSubscriber subscriber1 = new clsSubscriber("Ahmed");
            clsSubscriber subscriber2 = new clsSubscriber("Mohamed");
            clsSubscriber subscriber3 = new clsSubscriber("Siddig");
            clsSubscriber subscriber4 = new clsSubscriber("Ali");

            subscriber1.Subscribe(channel);
            subscriber2.Subscribe(channel);
            subscriber3.Subscribe(channel);
            subscriber4.Subscribe(channel);

            channel.UpploadVideo("C# Events Tutorial");

            Console.ReadKey();
        }
    }

    public class clsYoutubeChannel
    {
        public string Name { get; set; }
        public clsYoutubeChannel(string name)
        {
            this.Name = name;
        }

        public event EventHandler <string> VideoUploaded;
        public void UpploadVideo(string title)
        {
            Console.WriteLine($"{Name} Uploaded video: {title}");
            VideoUploaded (this, title);
        }

    }
    public class clsSubscriber
    {
        public string Name { get; set; }
        public clsSubscriber(string name)
        {
            this.Name = name;
        }

        public void Subscribe(clsYoutubeChannel channel)
        {
           channel.VideoUploaded += ReceiveNotification;
        }
        public void ReceiveNotification(object sender, string videoTitle)
        {
            clsYoutubeChannel channel = (clsYoutubeChannel) sender ;

            Console.WriteLine($"{Name} received notification: {channel.Name} uploaded a new video: {videoTitle}");
        }
    }
}
