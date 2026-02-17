using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_demo
{
    internal  class Dog : Animal // клас Dog наслідує (успадковує) від абстрактного класу Animal, тобто успадковує автовластивості Nickname, Age, метод Sleep(),
                                // і зобов'язаний реалізувати абстрактний метод MakeSound()
    {
        string Breed { get; set; }

        public override string Food => "meat, bones,...";

        public Dog(string nickname = "Nonick", int age = 0, string breed = "NoBreed")
            : base(nickname, age)
        {
            Breed = breed;
        }
        public override void MakeSound() // реалізація абстрактного методу MakeSound() для класу Dog
        {
            Console.WriteLine($"Dog '{Nickname}' ({Age} years) says: Woof!");
        }
    }
}
