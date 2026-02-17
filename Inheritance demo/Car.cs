using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_demo
{
    public enum EngineType { Electric, Fuel, Hybrid}
    public class Car : Vehicle // похідний від базового Vehicle
        // Car успадкував усі нестатичні поля, методи
    {
        public EngineType EngineType { get; set; } = EngineType.Fuel;
        public Car() { }
        public Car(string brand, int year, EngineType engineType = EngineType.Fuel)
            : base(brand, year) // виклик конструктора базового класу
        {
            this.EngineType = engineType;
        }

        public override void Move()
        {
            Console.WriteLine($"Car '{Brand}' moves on road...");
        }
        public new void Start() // new  - перекриває успадкований
        {
            Console.WriteLine($"Car '{Brand}' starts...");
        }
        public override string ToString()
        {
            //return $"Car '{brand}' {year}"; // year - OK, protected,   brand  - не доступний  
            return $"Car '{Brand}' {year} {EngineType} speed : {speed}"; // OK, Brand - public property
        }
    }
}
