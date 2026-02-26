//using System;
using System.Collections.Generic;


// SortedDictionary <> - складається з  пар, впорядкована по  ключу,
// організована як дерево  бінарного пошуку
SortedDictionary<string, int> sd = new SortedDictionary<string, int>()
{
    ["BMW"] = 45_000,
    ["Toyota"] = 37_000,
    ["Audi"] = 25_000,
};
if(sd.TryAdd("Mercedes", 50_000)) // - намагається додати пару,  якщо можливо(тобто ключа немає), повертає істину, якщо пара додалася
{
    Console.WriteLine("Pair 'Mercedes' : 50000] was added");
}

if (!sd.TryAdd("BMW", 50_000)) // - не додасть пару,  оскільки ключ 'BMW' вже існує, повертає false
{
    Console.WriteLine("Pair 'BMW' : 50000] was NOT added");
}

Console.WriteLine("_____Sorted dictionary_____");
foreach (var p in sd)
{
    Console.WriteLine($"Car : '{p.Key}'\tPrice :{p.Value}");
}

// Dictionary <> - складається з  пар, 
// організована як хеш-таблиця, пошук по ключу супер швидкий

Console.WriteLine("_____Dictionary (unsorted)_____");
Dictionary<string, int> dd = new Dictionary<string, int>()
{
    ["Wardrobe"] = 15_000,
    ["Door"] = 17_000,
    ["Lamp"] = 1_000,
};

foreach (var p in dd)
{
    Console.WriteLine($"Furniture : '{p.Key}'\tPrice :{p.Value}");
}

dd.TryGetValue("Door", out int price); // намагаємося отримати доступ на читання по ключу, якщо ок - у price буде value пари

