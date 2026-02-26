using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_realiz
{
    class TV : IEnumerable
    {
        private List<Channel> channels;
        private List<Channel> radioChannels;
        public TV()
        {
            channels = new List<Channel>()
            {
                new Channel(){ Number = 1, Name ="First Channel"},
                new Channel(){ Number = 2, Name ="Movie Channel"},
                new Channel(){ Number = 3, Name ="Espresso"},
                new Channel(){ Number = 4, Name ="ICTV"},
                new Channel(){ Number = 5, Name ="Child Channel"},
            };
            radioChannels = new List<Channel> 
            {
                new Channel(){ Number = 100, Name = "Radio Maximum"},
                new Channel(){ Number = 101, Name = "Наше радіо"},
                new Channel(){ Number = 102, Name = "Hit FM"}
            };
        }
        public void AddTVChannel(Channel channel)
        {
            channels.Add(channel);
        }

        public IEnumerator GetEnumerator() // неявний ітератор, повертає  перелічувач для колекції каналів,
                                           // який буде використовуватися циклом foreach для обходу каналів
        {
            foreach (var ch in channels)
            {
                // під капотом компілятор  зробить нам перелічувач,  у зовн. світ повертається поточне значення по перелічувачу
                yield return ch; // yield return - після повернення поточного значення, вернемося сюди для продовження 
            }
            foreach (var ch in radioChannels)
            {
                yield return ch; // yield return - після повернення поточного значення, вернемося сюди для продовження 
            }
            // return channels.GetEnumerator(); // ліниво, але вірно = повернули перелічувач для списку  channels
        }

        public IEnumerable<Channel> RadioChannels() // явний  іменований ітератор, повертає  ітерабельну колекцію з радіоканалів,
                                                    // будемо використовувати також циклом foreach для обходу радіоканалів  tv.RadioChannels()
        {

            foreach (var ch in radioChannels)
            {
                yield return ch; // yield return - після повернення поточного значення, вернемося сюди для продовження 
            }
            
        }
        public IEnumerable<Channel> ChannelsLessNumber(int number) // явний  іменований ітератор з  параметром,
                                                                   // поверне  ітерабельну колекцію з каналів із номерами менше рівне заданого 
        {
            foreach (Channel ch in this)
            {
                if (ch.Number <= number)
                    yield return ch;
                //if(ch.Number % 4 == 0) 
                //    yield break; // достроковий вихід  з  ітератора
            }
        }
        public void Print()
        {
            foreach (Channel ch in channels)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
