// See https://aka.ms/new-console-template for more information
// Колекція C# - це об'єкт, який групує кілька елементів в один об'єкт.
// Колекції використовуються для зберігання та управління групами об'єктів,
// таких як списки, масиви, словники тощо.
// Вони надають різні методи та властивості для додавання, видалення та доступу до елементів у колекції.
// Вони забезпечують спосіб зберігання та організації даних.
// Дві популярні колекції в C# - це ArrayList та List<>.
// Колекції можна поділити на дві основні категорії: неузагальнені (non-generic) та узагальнені (generic).

// Non-generic колекції, такі як ArrayList, можуть зберігати об'єкти будь-якого типу (object),
// але вони не забезпечують типобезпеку, що може призвести до помилок під час виконання.

using System.Collections;

Console.WriteLine("_____ArrayList vs List<> demo_____");
// ArrayLIst - організований як масив, але може змінювати свій розмір динамічно. Він зберігає елементи як об'єкти типу object
ArrayList arrayList = new ArrayList(4); // створення ArrayList з початковою ємністю 4
arrayList.Add(1); // додавання цілого числа 1 до ArrayList
Console.WriteLine($"Count: {arrayList.Count}, Capacity : {arrayList.Capacity}");
arrayList.Add("Hello"); // додавання рядка "Hello" до ArrayList
Console.WriteLine($"Count: {arrayList.Count}, Capacity : {arrayList.Capacity}");
arrayList.Add(3.14); // додавання числа з плаваючою точкою 3.14 до ArrayList
Console.WriteLine($"Count: {arrayList.Count}, Capacity : {arrayList.Capacity}");
arrayList.Add(true); // додавання булевого значення true до ArrayList
Console.WriteLine($"Count: {arrayList.Count}, Capacity : {arrayList.Capacity}");
arrayList.Insert(1, "C#");
Console.WriteLine($"Count: {arrayList.Count}, Capacity : {arrayList.Capacity}");

PrintList(arrayList, true);

arrayList.Remove(3.14); // видалення числа з плаваючою точкою 3.14 з ArrayList
arrayList.RemoveAt(0); // видалення елемента за індексом 0 з ArrayList
Console.WriteLine("\n_______After removing 3.14 and element #0");
PrintList(arrayList);

int index = arrayList.IndexOf("Hello"); // отримання індексу рядка "Hello" в ArrayList
Console.WriteLine($"\nIndex of 'Hello': {index}");

arrayList.SetRange(0, new object[] { "World", 42 }); // заміна елементів в ArrayList на нові значення
Console.WriteLine("\n_______After setting new range");
PrintList(arrayList);

arrayList[1] = "Two"; 
arrayList[2] = "Three"; 
arrayList.Sort(); // сортування елементів в ArrayList (може викликати помилку, якщо елементи не можна порівнювати між собою, різного типу)
Console.WriteLine("\n_______After changing and sorting");

PrintList(arrayList);

Console.WriteLine("___List<string>___________");
// generic колекції, такі як List<T>, забезпечують типобезпеку, що озна��ає, що вони можуть зберігати лише об'єкти
// певного типу (у цьому випадку рядки), що допомагає уникнути помилок під час виконання.
// тут не буде пакування для value- типів
List<string> list = new List<string>(); // створення List<string> для зберігання рядків
list.Add("Program"); // додавання рядка "Hello" до List<string>
list.Add("Generics"); // додавання рядка "Hello" до List<string>
list.Add("Collection"); // додавання рядка "Hello" до List<string>
list.AddRange(new string[] { "Demo", "ArrayList", "List", "One" }); // додавання кількох рядків до List<string> за допомогою AddRange
PrintList(list);

list.Remove("Generics"); // видалення рядка "Generics" з List<string>
list.RemoveAt(0); // видалення елемента за індексом 0 з List<string>    
list.Insert(1, "Interface"); // вставка рядка "C#" на позицію з індексом 1 в List<string>
list.Sort(); // сортування елементів в List<string> за алфавітом
Console.WriteLine("\n_____After changing and sorting");
PrintList(list);

Console.WriteLine($"Does list contain 'Program' : {list.Contains("Program")}");
list.RemoveAll(IsShortString); // вилучаємо елементи- рядки, які мають довжину менше 5
Console.WriteLine("\n____After removing short words from list");
PrintList(list);
void PrintList(ICollection list, bool withTypes = false)
{
    foreach (var item in list)
    {
        if (withTypes)
        {
            Console.WriteLine($"{item} (type: {item.GetType()})");
        }
        else
        {
            Console.WriteLine(item);
        }
    }
}
bool IsShortString(string str)
{
    return str.Length < 5;
}