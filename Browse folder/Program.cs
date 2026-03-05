using System;
using System.IO;

string path;
Console.WriteLine("Entre folder path : ");
path = Console.ReadLine()!;
PrintFolder(path);

static void PrintFolder(string path)
{
    //Directory   DirectoryInfo
    DirectoryInfo di = new DirectoryInfo(path);
    if (!di.Exists)
    {
        Console.WriteLine($"Folder {path} not found");
        return;
    }
    //foreach (DirectoryInfo d in di.EnumerateDirectories())
    //{

    //    //Console.WriteLine($"{d.FullName}");
    //    Console.WriteLine($"{d.CreationTime, -20}{d.Name, -40} <DIR>");
    //}
    //foreach (FileInfo f in di.EnumerateFiles())
    //{

    //    Console.WriteLine($"{f.CreationTime, -20}{f.Name, -40} {f.Length}");
    //}
    foreach (var f in di.EnumerateFileSystemInfos())
    {
        string info = "<DIR>";
        if (!f.Attributes.HasFlag(FileAttributes.Directory))
            info = (f as FileInfo)?.Length.ToString() ?? "";
        Console.WriteLine($"{f.CreationTime,-20}{f.Name,-40} {info}");

    }
}


