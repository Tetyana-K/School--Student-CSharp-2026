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
    Console.WriteLine($"Target site : {ex.TargetSite}");
    Console.WriteLine($"Data : {ex.Data}");
    Console.WriteLine($"Stack trace : {ex.StackTrace}");
}
catch (OverflowException ex)
{
    Console.WriteLine($"Message error : {ex.Message}");
    foreach (var key in ex.Data.Keys)
    {
        Console.WriteLine($"Additional data: {key} : {ex.Data[key]}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Some other exception: {ex.Message}");
}
double Div(double first, double second)
{
    if (second == 0)
    {
        throw new DivideByZeroException("Denominator cannot be zero.");
    }
    if (second > 1000)//int.MaxValue)
    {
        var error = new OverflowException("Denominator is too large.");
        error.Data.Add("DenominatorValue", second);
        error.Data.Add("Timestamp", DateTime.Now);   
        throw error;
    }
    return first / second;
}

