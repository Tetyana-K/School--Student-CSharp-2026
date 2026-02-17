using Inheritance_demo;
using Try_use_Vehicle_Car__Inheritance_;
Vehicle v = new Vehicle("Ford", 2018);
Console.WriteLine(v);
// v.Start(); // Помилка, бо метод Start() має модифікатор internal, і не доступний з іншого проекту (збірки)

Car car = new Car("Audi", 2020, EngineType.Hybrid);
Console.WriteLine(car);

Bus bus = new Bus("Mercedes", 2015, 50);
Console.WriteLine(bus);

