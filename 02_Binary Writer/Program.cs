using System;
using System.IO;

string fname = "info.dat";

using (BinaryWriter bw = new BinaryWriter(new FileStream(fname, FileMode.Create)))
{
    int value = 100;
    double valueD = 12.345;
    string str = "Hello! Привіт!";
    DateTime now = DateTime.Now;

    bw.Write(value); // записали у файл ціле число, при записі типу даних,  BinaryWriter автоматично перетворює його у послідовність байтів і зберігає у файл
    bw.Write(valueD);
    bw.Write(str);
    bw.Write(now.ToString()); // зберегли дату як рядок, тому будемо потім читати як рядок

    int[] arr = { 10, -20, 30, 40, 50, 88, 77 };
    bw.Write(arr.Length);// пишемо у файл число елементів масиву (int)
    foreach (var item in arr)
    {
        bw.Write(item); // пишемо у файл кожен елемент масиву (int),
                        // при читанні ми повинні знати, що спочатку йде розмір масиву, а потім стільки ж цілих чисел
    }

    ConsoleColor backColor = ConsoleColor.Green;
    bw.Write((int)backColor); // записали у файл ціле число, яке відповідає константі ConsoleColor.Green, при читанні ми повинні знати, що це ціле число, яке потрібно перетворити у ConsoleColor
    bw.Write(ConsoleColor.Yellow.ToString());
    // bw.Dispose(); // звільняє всі ресурси, пов'язані з потоком, включаючи закриття потока. Після виклику Dispose() потік більше не может быть использован для чтения или записи данных.
}
using (BinaryReader br = new BinaryReader(new FileStream(fname, FileMode.Open)))
{
    int value = br.ReadInt32(); // прочитали з  файлу ціле число
    double valueD = br.ReadDouble();
    string str = br.ReadString();

    string dateStr = br.ReadString(); // читаємо дату як рядок
    DateTime date = DateTime.Parse(dateStr);

    Console.WriteLine($"Int    = {value}");
    Console.WriteLine($"Double = {valueD}");
    Console.WriteLine($"String = '{str}'");
    Console.WriteLine($"Date   =  {date}");

    int[] arr = new int[br.ReadInt32()]; // br.ReadInt32() прочитали з  файлу розмір масиву і створили такого розмір масив
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = br.ReadInt32();
    }
    foreach (var item in arr)
    {
        Console.Write($"{item,5}");
    }

    ConsoleColor backColor = (ConsoleColor)br.ReadInt32();
    ConsoleColor foreColor = Enum.Parse<ConsoleColor>(br.ReadString());
    Console.BackgroundColor = backColor;
    Console.ForegroundColor = foreColor;
    Console.WriteLine("Demo");
}
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.Title = "HELLO";
            //Console.WriteLine("Demo");
        
