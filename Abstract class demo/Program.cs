using Abstract_class_demo;

//Animal a = new Animal("Name", 1); // помилка, НЕ МОЖНА створити об'єкт абстрактного класу
Cat cat = new Cat("Murka", 3, "Black");
cat.MakeSound();
cat.Sleep();

Dog dog = new Dog("Sharik", 5, "Bulldog"); // помилка, НЕ МОЖНА створити об'єкт абстрактного класу
dog.MakeSound();
dog.Sleep();

Animal animal = new Cat("Vaska", 2, "White"); // можна створити об'єкт похідного класу і присвоїти його змінній типу абстрактного класу
// animal тепер посилається на об'єкт типу Cat
animal.MakeSound();
animal.Sleep();

animal = new Dog("Bob", 4, "Labrador"); // можна створити об'єкт похідного класу і присвоїти його змінній типу абстрактного класу
// animal тепер посилається на об'єкт типу Dog
animal.MakeSound();
animal.Sleep();

Animal[] animals = new Animal[] // масив типу абстрактного класу, який може містити об'єкти похідних класів
{
   cat, 
   dog,
   animal, 
   new Cat("Nicy", 2, "Red"), 
};
Console.WriteLine($"\n_____ Animals Array _____");
foreach (var a in animals)
{
    a.MakeSound();
    a.Sleep();
    Console.WriteLine($"Food: {a.Food}"); 
    Console.WriteLine();
}