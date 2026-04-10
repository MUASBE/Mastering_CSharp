using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{

    // how to use delegates in use case senario of observer pattern

    public delegate void DelVideoUploadedEventHandler(string videoName);

    internal class Program
    {
        static void Main(string[] args)
        {

            clsYoutubeChannel YoutubeChannel = new clsYoutubeChannel("Programming Advices");

            clsSubscriber Subscriber1 = new clsSubscriber("Musab");
            clsSubscriber Subscriber2 = new clsSubscriber("Ahmed");
            clsSubscriber Subscriber3 = new clsSubscriber("Ali");
            clsSubscriber Subscriber4 = new clsSubscriber("Khalid");

            Subscriber1.Subscribe(YoutubeChannel);
            Subscriber2.Subscribe(YoutubeChannel);
            Subscriber3.Subscribe(YoutubeChannel);
            Subscriber4.Subscribe(YoutubeChannel);



            while (true)
            {
                Console.Write("\nUpload video: ");
                string videoName = Console.ReadLine();

                YoutubeChannel.UploadVideo(videoName);

            }



        }
    }

    public class clsYoutubeChannel
    {

        public event DelVideoUploadedEventHandler VideoUploadedEventHandler;

        public string ChannelName { get; set; }

        public clsYoutubeChannel(string channelName)
        {
            this.ChannelName = channelName;
        }
        public void UploadVideo(string VideoName)
        {
            Console.WriteLine($"{ChannelName} uploaded {VideoName}");
            VideoUploadedEventHandler?.Invoke(VideoName);
        }

    }

    public class  clsSubscriber
    {
        public string SubscriberName { get; set; }

        public clsSubscriber(string subscriberName)
        {
            this.SubscriberName = subscriberName;
        }

        public void Subscribe(clsYoutubeChannel channel)
        {
            channel.VideoUploadedEventHandler += Notify;
        }

        public void Notify(string videoName)
        {
            Console.WriteLine($"{SubscriberName} received notification of new video: {videoName}");
        }

    }


}
