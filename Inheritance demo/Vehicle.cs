using System;

namespace Inheritance_demo
{
    // internal - клас буде видно у цій збірці
    // public  - клас буде видно у всіх збірках (проектах)
    // sealed class - від класу не можна буже успадкуватися
    internal /*sealed*/ class Vehicle
    {
        private string brand; // доступно тільки у цьому класі, не видимо ззовні, у в похідних класах
        protected int year; // доступно у цьому класі, у в похідних класах, але не видимо ззовні
        public string Brand
        {
            get => brand;
            set => brand = value ?? "NoBrand";
        }
        public Vehicle(string brand = "Nobrand", int year = 2000)
        {
            Brand = brand;
            this.year = year;
        }
        public virtual void Move()
        {
            Console.WriteLine($"Vehicle '{Brand}' moves ...");
        }
        public void Start()
        {
            Console.WriteLine($"Vehicle '{Brand}' starts...");
        }
        public override string ToString()
        {
            return $"Vehicle '{brand}' {year}";
        }
    }
}
