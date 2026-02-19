using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal class Bird : IFly, INamed // клас Bird реалізує інтерфейс IFly, тобто зобов'язаний реалізувати всі методи та властивості, визначені в інтерфейсі IFly
    {
        private int height; // поле для зберігання значення властивості Height
        public int Height // реалізація властивості full property Height з інтерфейсу IFly
        {
            get => height;  // геттер повертає значення поля height
            set => height = value < 0 ? 0 : value;  // сеттер присвоює значення полю height
        }
        public string Name { get ; set ; } // реалізація властивості Name з інтерфейсу INamed у вигляді автоматичної властивості

        ////public  int Height { get; set; } // реалізація властивості Height з інтерфейсу IFly у вигляді автоматичної властивості
        public void Fly() // реалізація методу Fly() з інтерфейсу IFly
        {
            Console.WriteLine($"Bird {Name} is flying at {Height} meters.");
        }

        public void Move()
        {
            Console.WriteLine($"Bird {Name} is moving on the ground...");
        }
    }
}
