using System;

namespace Inheritance_demo
{
    // internal - клас буде видно у цій збірці
    // public  - клас буде видно у всіх збірках (проектах)
    // sealed class - від класу не можна буже успадкуватися

    // internal для класу (типу) - доступно тільки у цьому проекті, не видимо ззовні, у в похідних класах
    // internal для полів, методів - доступно тільки у ЦЬОМУ ПРОЕКТІ, не видимо ззовні, у в похідних класах,
    // для чужих класів як private, для своїх класів як public
    
    // protected для полів, методів - доступно у цьому класі, у в похідних класах, але не видимо ззовні
    
    // protected internal - доступно у цьому класі, у в похідних класах, але не видимо ззовні, і також доступно у цьому проекті, але не видимо ззовні

    // private protected - private для чужих класів, protected для своїх класів
    public /*sealed*/ class Vehicle
    {
        private protected int speed; // для експерименту
       
        private string brand; // доступно тільки у цьому класі, не видимо ззовні, у в похідних класах
        protected internal int year; // доступно у цьому класі, у в похідних класах, але не видимо ззовні
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
        internal void Start()
        {
            Console.WriteLine($"Vehicle '{Brand}' starts...");
        }
        public override string ToString()
        {
            return $"Vehicle '{brand}' {year} speed : {speed}";
        }
    }
}
