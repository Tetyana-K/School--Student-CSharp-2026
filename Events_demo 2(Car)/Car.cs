using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_demo_2_Car_;

delegate void FewFuelHandler(Car car, string message); // 1 визначили делегат для події
class Car
{
    const int fastSpent = 2;
    const int middleSpent = 1;
    const int lowFuel = 5;
    private int fuel;
    public event FewFuelHandler FewFuel; // 2) створили подію(об`єкт делегату) 
    public string Brand { get; set; }
    public int Fuel 
    {
        get => fuel;
        set 
        {

            fuel = value >= 0 ? value : 0;
            if (fuel <= lowFuel)
            {
                FewFuel?.Invoke( this, "Attention!!!! Low fuel in car!"); // 3) ініціювання події Мало  Палива(позапускаються методи, приєднані на делегат)
            }
        }
    }

    public Car(string  brand = "Nobrand", int fuel = 50)
    {
        Brand = brand;
        Fuel = fuel;
    }
    public override string ToString()
    {
        return $"Car : '{Brand}'\tFuel : {Fuel}";
    }
    public void GoFast(int km)
    {
        Console.WriteLine($"Fast trip {km} km, need spent {km * fastSpent}");
        Fuel -= km * fastSpent;
    }
    public void GoMiddle(int km)
    {
        Console.WriteLine($"Middle trip {km} km, need spent {km * middleSpent}");
        Fuel -= km * middleSpent;
    }
}
