using Implement_std__IComparable;
using System.Collections;

int value = 5;
int value2 = 10;
Console.WriteLine($"{value} compareTo {value2} = {value.CompareTo(value2)}"); //  -1

string str1 = "Hello world!";
string str2 = "Hello student!";
Console.WriteLine($"'{str1}' compareTo '{str2}' = {str1.CompareTo(str2)}\n"); // 1


// List<Device> - це колекція, яка може зберігати об'єкти типу Device.
// Вона надає методи для додавання (Add), видалення (Remove) та сортування (Sort) елементів.
List<Device> devices = new List<Device>
{
    new Device("Tablet", 800),
    new Device("Laptop", 1500),
    new Device("Phone", 799),
    new Device("Monitor", 1200),
};

devices.Add(new Device("SmartWatch", 400)); // Додаємо новий пристрій до списку за допомогою методу Add

Console.WriteLine("Before sorting:");
foreach (var device in devices)
    Console.WriteLine(device);

devices.Sort();  // метод Sort () використовує для порівняння метод CompareTo з інтерфейсу IComparable

Console.WriteLine("\nAfter sorting:");
foreach (var device in devices)
    Console.WriteLine(device);

// ArrayList - це колекція, яка може зберігати об'єкти будь-якого типу (як object),

ArrayList arrayList = new ArrayList
{
    new Device("IPhone", 999),
    new Device("Xiaomi", 755),
    new Device("Xbox", 1299),
};
arrayList.Add(new Device("PlayStation", 1099)); // Додаємо новий пристрій до ArrayList за допомогою методу Add
arrayList.Sort(); // метод Sort () використовує для порівняння метод CompareTo з інтерфейсу IComparable
Console.WriteLine($"\nAfter sorting ArrayList:");
foreach (var d in arrayList)
{
    Console.WriteLine(d);
}