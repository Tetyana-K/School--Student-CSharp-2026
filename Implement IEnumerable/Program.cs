using System;

namespace IEnumerable_realiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TV tv = new TV();
            tv.AddTVChannel(new Channel() { Number = 6, Name = "K-1" });
            Console.WriteLine(tv);

            //tv.Print();
            Console.WriteLine("___________All  channels______________");
            foreach (Channel ch in tv) //застосували неявний ітератор
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine("\n___________Radio  channels______________");
            foreach (Channel ch in tv.RadioChannels()) //застосували явний ітератор RadioChannels()
            {
                Console.WriteLine(ch);
            }
            int number = 50;
            Console.WriteLine($"\n___________Channels_with number <= {number}_____________");
            foreach (Channel ch in tv.ChannelsLessNumber(number)) //застосували явний ітератор ChannelsLessNumber()
            {
                Console.WriteLine(ch);
            }
        }
    }
}
// 
