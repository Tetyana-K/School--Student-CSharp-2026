using System;

class Program
{
    static void Main()
    {
        try
        {
            DoWork();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Main зловив виняток: {ex.GetType().Name}");
            Console.WriteLine($"Message : {ex.Message}");
        }
    }

    static void DoWork()
    {
        try
        {
            Process();
        }
        catch (Exception ex) when (Log(ex)) // блок catch виконається лише якщо Log(ex) поверне true
        {
            Console.WriteLine("Catch in DoWork()");
            throw; // повторно кидаємо виняток для обробки у вищому рівні (Main)
        }
    }

    static void Process()
    {
        int x = 0;
        int y = 10 / x; //тут летить виняток DivideByZeroException
    }

    static bool Log(Exception ex)
    {
        Console.Write(">>> Логування: летить виняток ");
        Console.WriteLine(ex.GetType().Name);
        return false; // це важливо, щоб блок catch не виконувався
    }
}
