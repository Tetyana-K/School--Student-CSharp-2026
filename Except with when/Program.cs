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
        catch (Exception ex) when (Log(ex))
        {
            throw;
        }
    }

    static void Process()
    {
        int x = 0;
        int y = 10 / x; // DivideByZeroException
    }

    static bool Log(Exception ex)
    {
        Console.Write(">>> Логування: ");
        Console.WriteLine(ex.GetType().Name);
        return false; // це важливо, щоб блок catch не виконувався
    }
}
