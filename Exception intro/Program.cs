Console.WriteLine($"Input value 1:");
double value1 = double.Parse(Console.ReadLine()!); // ! null-forgiving operator, щоб уникнути попередження компілятора

Console.WriteLine($"Input value 2:");
double value2 = double.Parse(Console.ReadLine()!);

try
{
    double result = Div(value1, value2);
    Console.WriteLine($"Result: {result}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Message error : {ex.Message}");
    Console.WriteLine($"Exception type : {ex.GetType().Name}");
    Console.WriteLine($"Source : {ex.Source}");
    Console.WriteLine($"Target site : {ex.TargetSite}");
    Console.WriteLine($"\nStack trace : {ex.StackTrace}");
}
catch (OverflowException ex) //when (ex.Data.Contains("too small"))
{
    Console.WriteLine($"Message error : {ex.Message}");
    foreach (var key in ex.Data.Keys) // перебираємо всі ключі у колекції Data винятку
    {
        Console.WriteLine($"Additional data: {key} : {ex.Data[key]}");
    }
}
catch (Exception ex) // Exception - базовий для усіх винятків, ловимо всі інші винятки
{
    Console.WriteLine($"Some other exception: {ex.Message}");
}
//catch
//{
//    Console.WriteLine("Unknown exception occurred.");
//}
finally
{
    Console.WriteLine("\nFinally always works"); // блок finally виконується завжди, окрім винятків, які призводять до аварійного завершення програми (наприклад, StackOverflowException)
}
double Div(double first, double second)
{
    if (second == 0)
    {
        throw new DivideByZeroException("Denominator cannot be zero.");
        // кидаємо виняток (помилку) типу DivideByZeroException
    }
    if (second > 1000)//int.MaxValue)
    {
        var error = new OverflowException("Denominator is too large.");
        error.Data.Add("Divisor Value", second); // додаємо додаткові дані до винятку (значення дільника)
        error.Data.Add("Timestamp", DateTime.Now);   // додаємо додаткові дані до винятку (поточний дату-час)
        throw error;
    }
    if (second < -1000)
        throw new OverflowException("Denominator is too small.");
    return first / second;
}

