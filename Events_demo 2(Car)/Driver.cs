using Events_demo_2_Car_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_demo_2_Car_;

class Driver // 4 клас у якому є  метод(и) для обробки події(метод має  підійти під  тип події) 
{
    public string? Name { get; set; }
    public void Refuel(Car car, string message) // 4
    {
        Console.WriteLine($"\nDriver {Name} notified about '{message}'");
        car.Fuel += 10;
        Console.WriteLine(car);
    }
}
