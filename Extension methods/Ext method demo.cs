
//PersonExtension person = new (){ Name = "Alice", Age = 30 };
//person.PrintInfo();

Person person = new (){ Name = "Alice", Age = 30 };
person.PrintInfo();
//PersonExtensions.PrintInfo(person);

int[] arr = { 10, 0, 5, 0, 3 };
double[] arr2 = { 10.8, 0, 5, 0, 3 };
arr.PrintArray();
//arr2.PrintArray();

Console.WriteLine($"Number of zeros: {arr.CountZeros()}");
Console.WriteLine($"Number of zeros (from index = 2): {arr.CountZeros(2)}");

sealed // не можна успадкуватися від цього класу
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
////class PersonExtension  // розширяє можливості класу Person, але не може бути його нащадком, працює як обгортка над класом Персона
////{
////    Person person = new Person();
////    public void PrintInfo()
////    {
////        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
////    }
////}


// метод розширення = метод, який дозволяє додавати нові методи до існуючих типів
// без зміни їх коду або створення нового типу, який наслідує від них.
// Метод розширення визначається як статичний метод у статичному класі,
// і перший параметр цього методу вказує тип, який він розширює, з ключовим словом this.

static class PersonExtensions // static клас, який містить метод розширення для класу Person
{
    public static void PrintInfo( this Person person) // метод розширення для класу Person, який приймає об'єкт Person як параметр
    {
        Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    }
}

static class ArrayExtension
{
    // метод розширення для масивів, який виводить елементи масиву довільного типу  на консоль
    public static void PrintArray<T>(this T[] array) // метод розширення для масивів, який приймає масив будь-якого типу як параметр
    {
        Console.WriteLine(string.Join(", ", array)); // виводить елементи масиву, розділені комами
    }
    public static int CountZeros(this int[] array, int index = 0 ) // метод розширення для масивів, який рахує кількість нулів у масиві
    {
        int count = 0;
        for (int i = index; i < array.Length; i++) // проходимо по масиву, починаючи з вказаного індексу
        {
            if (array[i] == 0) // якщо елемент масиву дорівнює нулю
            {
                count++; // збільшуємо лічильник нулів
            }
        }
        return count;
    }
}