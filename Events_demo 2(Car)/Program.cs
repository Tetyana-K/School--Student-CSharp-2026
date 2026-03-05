using Events_demo_2_Car_;

Car car = new Car("BMW");
Driver driver = new Driver { Name = "Ivan" };
Driver driver2 = new Driver { Name = "Olena" };

car.FewFuel += driver.Refuel; // += означає підписку на подію, тобто додавання методу-обробника до списку виклику при ініціюванні події
car.FewFuel += driver2.Refuel; // підписка другого водія (його метод Refuel) на подію

car.GoMiddle(20);
Console.WriteLine(car);

car.GoFast(20);
Console.WriteLine(car);
