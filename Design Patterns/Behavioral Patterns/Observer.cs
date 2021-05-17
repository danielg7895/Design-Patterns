using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    public class Observer
    {
        public void Main ()
        {
            Subscriptor sub1 = new Subscriptor("Melissa");
            Subscriptor sub2 = new Subscriptor("Asian Boss");
            Subscriptor sub3 = new Subscriptor("Lofi Girl");

            Channel me = new Channel("TheBestChannel");
            me.AddSubscriptor(sub1);
            me.AddSubscriptor(sub2);
            me.AddSubscriptor(sub3);

            me.UploadVideo();
        }

        public interface IChannel
        {
            public void UploadVideo();
            public void AddSubscriptor(Subscriptor subscriptor);
            public void RemoveSubscriptor(Subscriptor subscriptor);

        }

        public class Channel : IChannel
        {
            public string Name { get; set; }

            List<Subscriptor> subscriptors = new List<Subscriptor>();
            
            public Channel(string name)
            {
                Name = name;
            }

            public void AddSubscriptor(Subscriptor subscriptor)
            {
                subscriptors.Add(subscriptor);
            }

            public void RemoveSubscriptor(Subscriptor subscriptor)
            {
                subscriptors.Remove(subscriptor);
            }

            public void UploadVideo()
            {
                subscriptors.ForEach(sub => sub.Notify(this));
            }
        }

        public class Subscriptor
        {
            public string Name { get; set; }

            public Subscriptor(string name)
            {
                Name = name;
            }
            public void Notify(Channel channel)
            {
                Console.WriteLine($"{Name}: A new video from channel \"{channel.Name}\" was uploaded!");
            }
        }
    }
}
