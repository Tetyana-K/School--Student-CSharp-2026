// See https://aka.ms/new-console-template for more information
// top level statements feature

using Class_Ctors_Props;
using System.Net.WebSockets; // підключення простору імен Class_Ctors_Props для використання класу Car

Console.WriteLine("___Class Intro____");

//Class_Ctors_Props.Car car = new ();
//Car car = new (); // створення об'єкта класу Car за допомогою new та виклик конструктора за замовчуванням
Car car = new Car(); // створення об'єкта класу Car за допомогою new та виклик конструктора за замовчуванням
//car.SetBrand("Audi"); // виклик методу SetBrand для встановлення значення марки автомобіля
Console.WriteLine(car); // виведення рядкового представлення об'єкта car (викликається метод ToString())

Console.WriteLine($"Brand : {car.GetBrand()}");
//car.brand = "BMW"; // доступ до поля brand та його зміна -  зараз неможливий, оскільки поле оголошено як private
car.SetBrand("BMW"); // виклик методу SetBrand для встановлення значення марки автомобіля
Console.WriteLine($"Brand : {car.GetBrand()}");

Car car2 = new Car("Mercedes", 2020); // створення об'єкта класу Car за допомогою new та виклик конструктора з параметром
Console.WriteLine(car2);

car2.Year = 2023; //  використання властивості Year (set) для встановлення значення року випуску автомобіля з перевіркою
// value = 2023 - передаэться як value всередину set у властивості Year
car2.SetBrand("    "); // спроба встановити порожню марку автомобіля
Console.WriteLine(car2);
Console.WriteLine($"Yeat (get) = {car2.Year}"); // 2023 - використання властивості Year (get) для отримання значення року випуску автомобіля

