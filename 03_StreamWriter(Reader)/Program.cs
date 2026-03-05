using System;
using System.IO;

string path = "../../../my.txt"; // піднялися із  папки де exe у папку проекту
CreateTxtFile(path);
ShowFileFast(path);
ShowFileByLine(path);
ShowFileByChar(path);


static void ShowFileByChar(string path)
{
    Console.WriteLine("__________File content by  char Read()");
    using (StreamReader sr = new StreamReader(path))
    {
        int symbol = sr.Read(); // читаємо  із  файлу символ, повретають код символ
                                //while (!sr.EndOfStream)
        while (symbol != -1) // EOF = -1 доки не  прочитали ознаку кінця файлу 
        {
            Console.Write((char)symbol);
            symbol = sr.Read(); // читаємо наступний символ
        }
    }
}

static void ShowFileFast(string path)
{
    Console.WriteLine("__________File content  ReadToEnd()");
    using (StreamReader sr = new StreamReader(path))
    {
        string content = sr.ReadToEnd(); // прочитає  весь вміст файлу у рядок (від поточної позиції, зараз  - це початок файлу)
        Console.WriteLine(content);
    }
}

static void ShowFileByLine(string path)
{
    Console.WriteLine("__________File content  ReadLine()");
    using (StreamReader sr = new StreamReader(path))
    {
        string? line = sr.ReadLine(); // прочитає  рядок з  файлу - перший
        int i = 0;
        //while (! sr.EndOfStream) // доки не досягнули ознаки кінця потоку
        while (line != null) // доки змогли прочитати рядок з  файлу
        {
            Console.WriteLine($"#{++i} : {line}");
            line = sr.ReadLine();
        }
    }
}

static void CreateTxtFile(string path)
{
    using (StreamWriter sw = new StreamWriter(path, true)) // , true -  відкриваємо  текстовий файл  у режимі доповнення
    {
        //sw.BaseStream.Position = 0;
        string line;
        Console.WriteLine("Enter line : ");
        line = Console.ReadLine()!;
        sw.WriteLine(line); // записали рядок у файл

        Random rnd = new Random();

        for (int i = 0; i < 5; i++)
        {
            sw.Write($"{rnd.Next(100),5}"); // записали у файл 5 випадкових чисел, числа будуть одному рядку, бо ми використовуємо Write(), а не WriteLine()
        }
        sw.WriteLine(); // записали у файл символ нового рядка, щоб наступний запис був з  нового рядка
    }
}
