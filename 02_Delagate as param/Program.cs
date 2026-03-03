using System;

//1 неузагальнений делегат
delegate bool Check(int value);

//2 узагальнений делегат
delegate bool CheckU<T>(T value);
class Program
{
    // визначимо  метод подібний Array.FindIndex
    static int MyFindIndex(int[] arr, Check check) // check - параметр методу делегат, означає умову для пошуку
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (check(arr[i]))
                return i;
        }
        return -1;
    }

    // визначимо  метод подібний Array.FindIndex<>
    static int MyFindIndexU<T>(T[] arr, CheckU<T> check) // параметр методу делегат
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (check(arr[i]))
                return i;
        }
        return -1;
    }
    static void Main(string[] args)
    {
        int[] arr = { 10, 22, -4, -5, 100, 234 };
       // int index = MyFindIndex(arr, x => x < 0);
        int index = MyFindIndex(arr, IsPositive);
        if (index >= 0)
            Console.WriteLine($"First > 0 : {arr[index]}  with  index #{index}");
        
        index = MyFindIndexU(arr, x => x < 0);
        if (index >= 0)
            Console.WriteLine($"First < 0 : {arr[index]}  with  index #{index}");

        string[] words = { "delegate", "event", "collections", "dictionary" };
        char letter = 'v';
        index = MyFindIndexU(words, x => x.Contains(letter));
        if (index >= 0)
            Console.WriteLine($"First containі  '{letter}' : '{words[index]}'  with  index #{index}");
        
        bool IsPositive(int value) => value > 0; // локальна функція для перевірки додатності
    }
}