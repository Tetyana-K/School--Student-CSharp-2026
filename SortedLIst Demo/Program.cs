using System;
using System.Collections;
using System.Collections.Generic;

namespace SortedList_Demo;

struct Person
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"Person {Name}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        //SortedListDemo();
        SortedListGeneric();

    }

    private static void SortedListGeneric()
    {
        // SortedList<TKey, TValue> - колекція містить пари виду (TKey Key, TValue Value),
        // впорядкування по  ключу(за зростанням по замовчуванню),  ключі УНІКАЛЬНІ
        // організована у вигляді паралельних  масивів(Ключі, Значення)
        SortedList<string, string> voc = new SortedList<string, string>(30)
        {
            ["language"] = "мова",
            ["book"] = "книга",
            ["laptop"] = "ноутбук",
            ["memory"] = "пам'ять"
        };
        voc.Add("map", "карта, відображення");
        string key = "map";
        string value = "новий";

        voc.TryAdd(key, value); // - намагається додати пару,  якщо можливо(тобто ключа немає), повертає істину, якщо пара додалася 
        voc.TryAdd("new", value); //+ намагається додати пару,  якщо можливо(тобто ключа немає), повертає істину, якщо пара додалася 

        foreach (var p in voc)
        {
            Console.WriteLine($"{p.Key,-15} : {p.Value,-15}");
        }

        Console.WriteLine("\n___TryGetValue()_______");
        if (voc.TryGetValue(key, out string translate)) // намагаємося отримати доступ на читання по ключу, якщл ок - у translate буде value пари
        {
            Console.WriteLine($"{key} = {translate}");
        }
        key = "memory";
        if (voc.Remove(key, out translate)) // намагається вилучити пару, якщо  вилучена, то значення із  пари  запишеться  у translate
        {
            Console.WriteLine($"\nWas removed pair with  key '{key}'  and value  '{translate}'");
        }
        voc.RemoveAt(0); // вилучаємо пару за індексом
        PrintSL(voc, "\n_______________After removing");
    }

    private static void SortedListDemo()
    {
        // SortedList - колекція містить пари виду (object ключ Key, object значення Value),
        // впорядкування по  ключу(за зростанням), ключі одного типу, ключі УНІКАЛЬНІ
        // організована у вигляді паралельних  масивів(Ключі, Значення)
        SortedList sl = new SortedList(20)
            {
                //[1] = "Nastia",
                { 55555555, "Petro"},
                { 12121212, "Anna"},
                { 41444444, "Olesia"},
                { 33300000, "Vadim"},
                { 13300000, 12.45},
                { 73300000, true},
            };
        int key = 77777777;
        object value = new Person() { Name = "Ihor" };

        if (!sl.Contains(key))
        {
            sl.Add(key, value);
        }
        if (!sl.Contains(key))
        {
            sl.Add(key, value);
        }
        else
        {
            Console.WriteLine($"Add error : key {key} exists ");
        }
        PrintSL(sl, "_________________Sorted list");

        //[] set  - якщо пара існує, то змінюємо  значенння  пари,  якщо немає, то створиться НОВА пара 
        sl[56756711] = "new"; // додали нову пару 
        PrintSL(sl, "_________________Sorted list []");

        //[] get  - якщо пара існує, то  повертається значення(value)  із  пари
        //[] get  - якщо пари немає, то null

        Console.WriteLine($"Get by   [{key}] = {sl[key]}");
        key = 100;
        Console.WriteLine($"Get by   [{key}] = {sl[key]}"); // null

        sl.Remove(key); // вилучили пару по  ключу key
        sl.RemoveAt(0); // вилучили пару по  її індексу (№0)
        PrintSL(sl, "_________________Sorted list after removing");

        // організована у вигляді паралельних  масивів, тому підтримується робота на  рівні індексів пар
        Console.WriteLine("\n\t\tEnter  index of pair : ");
        int index = int.Parse(Console.ReadLine());
        if (index < sl.Count && index >= 0)
        {
            Console.WriteLine($"Index # {index} Key : {sl.GetKey(index)} Value : {sl.GetByIndex(index)}");
        }

        Console.WriteLine("\n________________Keys");
        foreach (var k in sl.Keys)
        {
            Console.Write($"{k,10}");
        }
        Console.WriteLine("\n\n________________Values");
        foreach (var v in sl.Values)
        {
            Console.Write($"{v,10}");
        }
        PrintSLInd(sl, "\n_____________SortedList");
    }

    private static void PrintSL(IDictionary sl, string text = "")
    {
        Console.WriteLine(text);

        foreach (DictionaryEntry p in sl)
        {
            Console.WriteLine($"{p.Key,10} : {p.Value}");
        }
    }
    private static void PrintSLInd(SortedList sl, string text = "")
    {
        Console.WriteLine(text);

        for (int i = 0; i < sl.Count; i++)
        {

            Console.WriteLine($"#{i + 1} {sl.GetKey(i)} : {sl.GetByIndex(i)}");
        }

    }
}

