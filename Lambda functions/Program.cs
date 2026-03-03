// See https://aka.ms/new-console-template for more information
Console.WriteLine("___Anonymous functions and lambda expressions___");
MyDelegate del = delegate  (string msg) // анонімна функція, яка приймає рядок і не повертає значення
{ // delegate - ключове слово для створення анонімної функції, яка не має імені і може бути присвоєна делегату
    // тіло анонімної функції, яка виконується при виклику делегата, виводить повідомлення на консоль
    Console.WriteLine($"Message: '{msg}'");
};

del("Some message...."); // виклик делегата, який виконує анонімну функцію


// лямбда-вираз, який приймає рядок і не повертає значення
//var lambda = (string name) => { Console.WriteLine($"Hello, {name}!"); Console.WriteLine("*****"); }; 
var lambda = (string name) => Console.WriteLine($"Hello, {name}!"); 
lambda("Ivan"); // виклик лямбда-функції, який виводить привітання з ім'ям

MyFunc sum = (int x, int y) => x + y; // лямбда-вираз, який приймає два цілі числа і повертає їх суму

int value1 = 5;
int value2 = 10;
Console.WriteLine($"Sum lambda({value1}, {value2}) = {sum(value1, value2)}");

MyPredicate isEven = (int number) => number % 2 == 0; // лямбда-вираз, який приймає ціле число і повертає true, якщо число парне, і false - якщо непарне
int numberToCheck = new Random().Next(1, 101); // випадкове число від 1 до 100
Console.WriteLine($"Number {numberToCheck} is even: {isEven(numberToCheck)}\n");


int[] numbers = new int[] { 1, 20, -3, 48, 58, 61, 7, 88, 9, -10 };
//Array.Sort(numbers); // сортування масиву за допомогою лямбда-виразу, який порівнює два числа

Array.Sort(numbers, (a, b) => b.CompareTo(a)); // сортування масиву за допомогою лямбда-виразу, який порівнює два числа
// було впорядковано по спаданню
Console.WriteLine("_____Sorted array");
foreach(var num in numbers)
{
    Console.Write($"{num} ");
}

List<Person> people = new List<Person>
{
    new Person() { Name = "Alice", Age = 30 },
    new Person() { Name = "Bob", Age = 25 },
    new Person() { Name = "Charlie", Age = 35 },
    new Person() { Name = "Diana", Age = 28 },
};

//Comparison<> - стд делегат, який визначає метод порівняння двох об'єктів одного типу і повертає ціле число, яке вказує на відносний порядок об'єктів 
//people.Sort((p1, p2) => p1.Age.CompareTo(p2.Age)); // сортування списку людей за віком за допомогою лямбда-виразу, який порівнює вік двох людей
people.Sort((p1, p2) => p2.Age.CompareTo(p1.Age)); // сортування списку людей за віком (за спаданням) за допомогою лямбда-виразу, який порівнює вік двох людей
Console.WriteLine("\n\n_____Sorted people by age");
foreach(var person in people)
{
    Console.WriteLine(person);
}   
people.Sort((p1, p2) => string.Compare(p1.Name, p2.Name)); // сортування списку людей за іменем за допомогою лямбда-виразу, який порівнює імена двох людей
Console.WriteLine("\n_____Sorted people by name");
foreach(var person in people)
{
    Console.WriteLine(person);
}

delegate void MyDelegate(string message); // оголошення делегата, який приймає рядок і не повертає значення
delegate int MyFunc(int x, int y); // оголошення делегата, який приймає два цілі числа і повертає ціле число
delegate bool MyPredicate(int value ); // оголошення делегата, який приймає ціле число і повертає булеве значення

struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"Person : {Name}, Age: {Age}";
    }
}