// ref - типи підтримують null
// value - типи НЕ підтримують null
// існує  обгортка над  value-типами Nullable<тип>

int a = 100;
//int b = null; // error

Nullable<int> b = null;
 //b = 222;
int? c = 200; // int ? синтаксичний цукор для Nullable<int>
//c = null;

Console.WriteLine($"a = {a}");
Console.WriteLine($"b = {b}");

if (b.HasValue)
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b == null");
}

Console.WriteLine($"b ?? 0 = {b ?? 0}");
Console.WriteLine($"c = {c}");

//int sum = (a + b); // помилка компіляції, при додавання int + int?  результат буде int?
//int sum = (int)(a + b); // помилка виконання (виняток), при зведенні null до int
//int sum = (c ?? 0) + (b ?? 0);
int sum = (c.GetValueOrDefault() + b.GetValueOrDefault());
Console.WriteLine($"\nsum = {sum}");

int product = (c.GetValueOrDefault(1) * b.GetValueOrDefault(1));
Console.WriteLine($"\nproduct = {product}");

if (b.HasValue)
{
    double avg = (double)(a + b) / 2.0; // явно перетворення від  int?  до double
}

Student student = new Student();
student.Name = "Alice";
student.Age = null; // вік невідомий

class Student
{
    public string Name { get; set; } = "Noname";
    public int? Age; // вік може бути невідомим (null)
}