// See https://aka.ms/new-console-template for more information
Console.WriteLine("_____________Tuples_____");

int a = 10, b = 15;
//int tmp = a;
//a = b;
//b = tmp;

(a, b) = (b, a); // обмін значеннями за допомогою кортежів

Console.WriteLine($"a: {a}, b: {b}"); // a: 15, b: 10

int[] numbers = { 3, 5, 7, 2, 8, -1, 4 };

//int max, min; // оголошення змінних для вихідних параметрів
//MaxMin(numbers, out  max, out  min); // виклик методу з вихідними параметрами
MaxMin(numbers, out int max, out int min); // оголошення змінних безпосередньо на "льоту" в аргументах виклику методу
Console.WriteLine($"Max: {max}, Min: {min}");

//(int max2, int min2) = MaxMin2(numbers);
(var max2, var min2) = MaxMin2(numbers); // var аналогічно auto у С++
Console.WriteLine($"\nMax2: {max2}, Min2: {min2}");

var result = MaxMin2(numbers);
Console.WriteLine(result);
Console.WriteLine($"Max = {result.Item1}, Min = {result.Item2}");
Console.WriteLine($"Max = {result.max}, Min = {result.min}");


void MaxMin(int[] numbers, out int max, out int min)
{
    max = numbers[0];
    min = numbers[0];
    foreach (var number in numbers)
    {
        if (number > max) max = number;
        if (number < min) min = number;
    }
}

(int max, int min) MaxMin2(int[] numbers) // ?
//(int, int ) MaxMin2(int[] numbers) // ?
{
    int max = numbers[0];
    int min = numbers[0];
    foreach (var number in numbers)
    {
        if (number > max) max = number;
        if (number < min) min = number;
    }
    return (max, min); // функція повертає кортеж із двох елементів
}