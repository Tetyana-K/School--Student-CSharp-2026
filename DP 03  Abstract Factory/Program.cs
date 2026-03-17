// See https://aka.ms/new-console-template for more information
using Abstract_Factory;

//Console.WriteLine("Without  Factory");

//IChair chair = new ModernChair();
//chair.SitOn();
//Console.WriteLine($"Has legs : {chair.HasLegs()}");

//ICoffeTable table = new ClassicCoffeeTable();
//table.DrinkCoffe();

Console.WriteLine("______ABSTRACT FACTORY______");
//IFurnitureFactory factory = new ModernFactory();
//IChair chair = factory.CreateChair(); // повернеться стілець із  фабрики ModernFactory
//chair.SitOn();
//Console.WriteLine($"Has legs : {chair.HasLegs()}");

//ICoffeTable table = factory.CreateCoffeTable(); // повернеться столик із  фабрики ModernFactory
//table.DrinkCoffe();

//factory = new  ClassicFactory();
//table = factory.CreateCoffeTable();
//table.DrinkCoffe();

Client client = new Client(new ClassicFactory()); // створили об'єкт Клієнта і передали туди об'єкт Класичної Фабрики
client.CreateFurniture(2);
client.PrintFurnitures();

