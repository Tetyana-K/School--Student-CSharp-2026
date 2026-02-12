using System;
// class Array - базовий абстрактний клас для всіх масивів у C#
Console.WriteLine("class Array");
int size = 7;
int[] numbers = new int [size];
FillRand(numbers);
PrintArray(numbers);

int[] copyNumbers = new int[numbers.Length + 2]; // створення масиву більшого розміру 0 0 0 0...0
numbers.CopyTo(copyNumbers, 2); // копіювання усього масиву numbers у copyNumbers, починаючи з індексу 2
PrintArray(copyNumbers);

int [] segmentArray = new int [numbers.Length]; // створення масиву для збереження сегмента
Array.Copy(numbers, 3, segmentArray, 1, 3);
PrintArray(segmentArray);

Console.WriteLine($"Clone of original array");
int[] cloneArray = (int[]) numbers.Clone(); // створення повної копії масиву 1) створиться новий масив 2) елементи будуть скопійовані
// (int []) - приведення від типу Object, який повертає метод Clone(), до типу int[]
PrintArray(cloneArray);

Console.WriteLine($"\nEnter number to find");
int value = int.Parse(Console.ReadLine()!);
int index = Array.IndexOf(numbers, value); // пошук індексу першого входження елемента зі значенням value або -1, якщо елемент не знайдено
Console.WriteLine($"Index of {value} is {index}");

Console.WriteLine($"\nExists elements divisible by 5");
bool existsDiv5 = Array.Exists(numbers, IsDiv5); // перевірка на існування елемента, що задовольняє умову предикату IsDiv5
Console.WriteLine($"Exists elements divisible by 5: {existsDiv5}");
if (existsDiv5)
{
    int indexDiv5 = Array.FindIndex(numbers, IsDiv5); // пошук індексу першого елемента, що задовольняє умову предикату IsDiv5
    Console.WriteLine($"Index of first element divisible by 5: {indexDiv5} element : {numbers[indexDiv5]}");
}

bool allDiv5 = Array.TrueForAll(numbers, IsDiv5); // перевірка чи всі елементи задовольняють умову предикату IsDiv5
Console.WriteLine($"All elements divisible by 5: {allDiv5}");

bool allPositive = Array.TrueForAll(numbers, IsPositive); // перевірка чи всі елементи задовольняють умову предикату IsDiv5
Console.WriteLine($"All elements positive: {allPositive}");

Console.WriteLine("\nEven elements from origin array:");
int[] evenNumbers = Array.FindAll(numbers, IsEven); // пошук усіх парних елементів
PrintArray(evenNumbers);
bool IsEven(int value) => value % 2 == 0; // локальна функція для перевірки парності (предикатна = логічна, повертає bool)
bool IsDiv5(int value) => value % 5 == 0; // локальна функція для перевірки кратності 5 (предикатна = логічна, повертає bool)
bool IsPositive(int value) => value > 0; // локальна функція для перевірки додатності
void FillRand(int[] arr, int minValue = 1, int maxValue = 100)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(minValue, maxValue);
    }
}
void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();
}