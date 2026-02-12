using Inheritance_demo;

Vehicle v = new Vehicle("Ford", 2018);
Console.WriteLine(v);
v.Move();
Console.WriteLine();

Car car = new Car(/*"Audi", 2020*/);
car.Brand = "Audi";
Console.WriteLine(car);

Car car2 = new Car("Toyota", 2022, EngineType.Fuel);
Console.WriteLine(car2);
car2.EngineType = EngineType.Hybrid;
car2.Move();
car2.Start();

Console.WriteLine($"_____Vehicles (array)____");
Vehicle[] vehicles = { v, car, car2, new Vehicle("ABC", 2017) };

foreach (Vehicle vehicle in vehicles)
{
    
    Console.WriteLine(vehicle);
    vehicle.Move();
    vehicle.Start(); //
    Console.WriteLine();
}
