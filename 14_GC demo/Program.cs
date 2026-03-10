// See https://aka.ms/new-console-template for more information

using _14_GC_demo;
int size = 50_000;
Console.WriteLine($"Number of generations : {GC.MaxGeneration + 1}, # 0 .. {GC.MaxGeneration}");
Console.WriteLine($"Allocated memory (before) : {GC.GetTotalAllocatedBytes(false)}");
MemoryEater? obj = new MemoryEater(size); // id = 1
Console.WriteLine($"Allocated memory after creating fisrt object : {GC.GetTotalAllocatedBytes(false)}");
MemoryEater obj2 = new MemoryEater(size); // id = 2
for (int i = 0; i < 100; i++)
{
    obj = new MemoryEater(size); // id = 3, 4, ...
}
Console.WriteLine($"Allocated memory (after creating 101 objects) : {GC.GetTotalAllocatedBytes(false)}");

Console.WriteLine($"Generation of obj {GC.GetGeneration(obj)}");
Console.WriteLine($"Generation of obj2 {GC.GetGeneration(obj2)}");

GC.Collect(); // примусова збірка сміття
GC.WaitForPendingFinalizers(); // очікування завершення фіналізації
Console.WriteLine($"Allocated memory : {GC.GetTotalAllocatedBytes(false)}");

Console.WriteLine($"\nGeneration of obj {GC.GetGeneration(obj)}");
Console.WriteLine($"Generation of obj2 {GC.GetGeneration(obj2)}");
Thread.Sleep(1000);
Console.WriteLine($"Allocated memory : {GC.GetTotalAllocatedBytes(true)}");
