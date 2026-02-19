using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_demo
{
    internal class Plane : IFly
    {
        public string Brand { get; set; }
        public int Height { get; set ; } // реалізація властивості Height з інтерфейсу IFly у вигляді автоматичної властивості
        public Plane(string brand, int height)
        {
            Brand = brand;
            Height = height;
        }
        public Plane() : this("NoBrand plane", 0)
        {
        }
        public void Move() // реалізація методу Move() з інтерфейсу IMove, який успадковується інтерфейсом IFly
        {
            Console.WriteLine($"Plane '{Brand}' is moving on the runway...");
        }
        public void Fly() // реалізація методу Fly() з інтерфейсу IFly
        {
            Console.WriteLine($"Plane '{Brand}' is flying at {Height} meters.");
        }
    }
}
