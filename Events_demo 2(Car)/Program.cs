
using Events_demo_2_Car_;

Car car = new Car("BMW");
Driver driver = new Driver { Name = "Ivan" };
Driver driver2 = new Driver { Name = "Olena" };

car.FewFuel += driver.Refuel; // safe for  event
car.FewFuel += driver2.Refuel; // safe for  event
car.GoMiddle(20);
Console.WriteLine(car);

car.GoFast(20);
Console.WriteLine(car);
