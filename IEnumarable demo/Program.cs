using System;
using System.Collections; //  IEnumerator, IEnumerable 


// IEnumerable //- можливість обходити об'єкт певного типу циклом foreach 
int[] arr = { 10, 2, 3, 11, 222 };
//foreach (var e in arr) // за сценою працюють методи 
//{
//    Console.WriteLine(e);
//}
//// перелічення - обєкт, по  якому можна  переміщатися
// перелічувач - обєкт,  який переміщається по  колекції

// низькорівневий обхід  масиву arr стандарнти перелічувачем(у С++ ми назвиали ітератор)
IEnumerator en = arr.GetEnumerator(); // отримали перелічувач, який може обходити масив arr
while (en.MoveNext()) // перемістилися вперед, нам повернули чи вдалося виконати переміщення
{
    Console.Write($"{en.Current,10}");
}
Console.WriteLine();
en.Reset(); // перелічувач перевели у початковий стан
while (en.MoveNext()) // перемістилися вперед, нам повернули чи вдалося виконати переміщення
{
    Console.WriteLine($"{en.Current,10}");
}

string str = "IEnumerable and IEnumerator";
IEnumerator enStr = str.GetEnumerator();
while (enStr.MoveNext()) // перемістилися вперед, нам повернули чи вдаллся виконати переміщення
{
    Console.Write($"{enStr.Current,2}");
}



