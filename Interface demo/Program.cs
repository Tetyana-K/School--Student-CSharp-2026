// See https://aka.ms/new-console-template for more information
using Interface_demo;

Console.WriteLine("_________Interface demo________");
Bird bird = new Bird() { Height = 12};
//bird.Height = 10;
bird.Fly();

IFly flyable = bird; // можна присвоїти об'єкт класу, який реалізує інтерфейс, змінній типу цього інтерфейсу
Console.WriteLine($"\tBird as IFly");
flyable.Fly();
flyable.Move(); 

INamed named = bird; // можна присвоїти об'єкт класу, який реалізує інтерфейс, змінній типу цього інтерфейсу
named.Name = "Sparrow";
Console.WriteLine("\tBird as INamed");
Console.WriteLine($"Bird's name is {named.Name}.\n");

Plane plane = new Plane("Boeing 747", 10000);
plane.Fly();

Console.WriteLine("\tPlane as IFly");
flyable = plane; // можна присвоїти об'єкт класу, який реалізує інтерфейс, змінній типу цього інтерфейсу
flyable.Fly();

// масив типу інтерфейсу, який може містити об'єкти класів, які реалізують цей інтерфейс
IFly[]flyables = new IFly[] 
{ 
    bird,
    plane,
    new Bird() { Height = 50, Name ="Eagle" },
};
Console.WriteLine("\n____________Array of flyable objects______");
foreach (var f in flyables)
{
    f.Move();
    f.Fly();
    Console.WriteLine();
}