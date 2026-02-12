//Console.ForegroundColor = ConsoleColor.Yellow;
//Console.BackgroundColor = ConsoleColor.Yellow;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write(' ');
//}
//Console.ResetColor();

Console.WriteLine(DoOperation(5, 10, 20));
Console.WriteLine(DoOperation(7, 10, 20));
Console.WriteLine(DoOperation(50, 10, 20));
Console.WriteLine(DoOperation(40, 10, 20));
int DoOperation(int op, int a, int b)
{
    int result = op switch
    {
        1 or 5 => a + b,
        2 => a - b,
        > 30  and < 50 => a * b,
        _ => 0 // _ в інакших випадках
    };
    return result;
}
