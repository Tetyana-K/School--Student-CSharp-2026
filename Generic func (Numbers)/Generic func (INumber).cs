
using System.Numerics;
int[] numbers = { 1, -2, -3, -4, 0, 0 };
double[] doubles = { 1.5, 2.5, -3.5 };

Console.WriteLine($"CountNegative([{string.Join(", ", numbers)}]):\t{CountNegative(numbers)}");  // 3
Console.WriteLine($"CountNegative([{string.Join(", ", doubles)}]):\t{CountNegative(doubles)}");  // 1

static int CountNegative<T>(T[] array) where T : INumber<T>
{
    int count = 0;

    foreach (var item in array)
    {
        if (item < T.Zero)
            ++count;
    }

    return count;
}
