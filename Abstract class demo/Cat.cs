using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_demo
{
    internal class Cat : Animal // клас Cat наслідує (успадковує) від абстрактного класу Animal, тобто успадковуэ автовластивості Nickname, Age, метод Sleep(),
                                // і зобов'язаний реалізувати абстрактний метод MakeSound()
    {
        public string Color { get; set; }

        public override string Food => "milk, cream, ...";

        public Cat(string nickname = "Nonick", int age = 0, string color = "NoColor") 
            : base(nickname, age)
        {
            Color = color;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"Cat '{Nickname}' ({ Age } years) says: Meow!");
        }
    }
}
