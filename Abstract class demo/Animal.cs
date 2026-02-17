using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_demo
{
    // Абстрактний клас - це клас, для якого не можна створити об'єкти,
    // і може містити абстрактні методи, які не мають реалізації, і повинні бути реалізовані у похідних класах.
    // Абстрактний клас може містити як АБСТРАКТНІ, так і ЗВИЧАЙНІ методи, а також поля, властивості, конструктори.
    internal abstract class Animal
    {
        public string Nickname { get; set; }
        public int Age { get; set; } // auto-property
        public Animal(string nickname = "Nonick", int age = 0)
        {
            Nickname = nickname;
            Age = age;
        }
        public abstract void MakeSound(); // абстрактний метод, який не має реалізації, і повинен бути реалізований у похідних класах
        public abstract string Food { get; } // абстрактна властивість, яка не має реалізації, і повинна бути реалізована у похідних класах
        public void Sleep() // звичайний метод, який має реалізацію, і може бути викликаний у похідних класах
        { 
             Console.WriteLine($"Animal '{Nickname}' is sleeping...");
        }
    }
}
