using System;
using System.Collections.Generic;
using System.IO;

//string path = "my.txt";
//string fileContent = "Test line!\n";
////File.WriteAllText(path, fileContent);
////File.AppendAllText(path, "Second line\nThird line\n");

//string[] words = { "program", "streams", "files" };
////File.AppendAllLines(path, words);


//if (File.Exists(path))
//{
//    Console.WriteLine($"File content:");
//    Console.WriteLine(File.ReadAllText(path));
//    Console.WriteLine($"\nFile content by line:");
//    string [] lines = File.ReadAllLines(path);
//    for (int i = 0; i < lines.Length; i++)
//        Console.WriteLine($"{i+1} : '{lines[i]}'");
//    //File.Move(path, @"d:\", true); // ???

//}

//File.Copy(path, @"D:\");


Console.WriteLine($"Current  path : {Directory.GetCurrentDirectory()}");
Directory.SetCurrentDirectory(@"D:\");// зміна поточної папки на D:\
Console.WriteLine($"Current  path : {Directory.GetCurrentDirectory()}");

string dirPath = "P-43";
DirectoryInfo dir;
if (Directory.Exists(dirPath)) // перевірили чи папка вже створена
{
    Console.WriteLine($">>>>>>>Folder  {dirPath} already  exists");
}
else
{
    dir = Directory.CreateDirectory(dirPath);
    Console.WriteLine($">>>>>>>>>>Folder was created ::: {dir.Exists}");
}
string fname;
Console.WriteLine("\n\t\tEnter  name of file  : ");
fname = Console.ReadLine()!;
string pathFname = Path.Combine(dirPath, fname); // dirPath\hello.txt
if (File.Exists(pathFname))
{
    Console.WriteLine($"File {pathFname} already  exist");
}
else
{
    Console.WriteLine($"We are going to create file {pathFname}");

    Console.WriteLine("\n\t\tEnter content (one line)");
    File.WriteAllText(pathFname, Console.ReadLine());

    List<string> lines = new List<string> { "\nC# Files", "Classes File and File Info", "Directory  and DirectoryInfo" };
    File.AppendAllLines(pathFname, lines);

    string content = File.ReadAllText(pathFname);
        Console.WriteLine("\n__________File content");
        Console.WriteLine(content);
}

FileInfo fi = new FileInfo(pathFname);
Console.WriteLine($"\n\nFile name : {fi.Name}");
Console.WriteLine($"Fullname  : {fi.FullName}");
Console.WriteLine($"Creation time : {fi.CreationTime}");
Console.WriteLine($"Access time : {fi.LastAccessTime}");
Console.WriteLine($"Size    : {fi.Length}");
Console.WriteLine($"Attributes    : {fi.Attributes}");

Console.WriteLine();
Console.WriteLine($"Attributes  folder {dirPath}   : {File.GetAttributes(dirPath)}");

Console.WriteLine("\n__________File content");
Console.WriteLine(File.ReadAllText(pathFname));

string pathCopy = Path.Combine(dirPath, "COPY"); // створили  рядок з таким шляхом D:\P-43\COPY
Directory.CreateDirectory(pathCopy);
File.Copy(pathFname, Path.Combine(pathCopy, fname)); // виняток, якщо  файл-копія вже існує
//File.Copy(pathFname, Path.Combine(pathCopy, fname), true); //можна копіювати поверх  файлу копії
//File.Move(pathFname, Path.Combine(pathCopy, fname)); // переміщення файлу, якщо  файл-копія вже існує, то виняток
Console.ReadKey();

File.Delete(pathFname);
Console.WriteLine($"After  deleting  file {pathFname} Exist :: {File.Exists(pathFname)}");
fi.Refresh(); // оновили інформацію про файл, оскільки ми його видалили, то інформація про існування файлу змінилася
Console.WriteLine($"After  deleting  file {pathFname} Exist :: {fi.Exists}");
Console.ReadKey();
//Directory.Delete(dirPath); // виняток,  якщо папка не  пуста
Directory.Delete(dirPath, true); // вилучення папки з  підпапками та файлами у ній
Thread.Sleep(2000); // затримка, щоб операційна система встигла видалити папку
Console.WriteLine($"After  deleting  directory {dirPath} Exist :: {Directory.Exists(dirPath)} ");
