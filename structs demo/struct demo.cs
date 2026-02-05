Person person = new Person(); // виклик конструктора за замовчуванням, об'єкт створюється на стеку
Console.WriteLine(person);

person.Name = "Alice";
person.Age = 18;
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);

ChangeAge(person); // Alice 19
DisplayPerson(person);

string name;
int age;
(name, age) = person; // розпакування об'єкта на окремі змінні (частини) - deconstruction
Console.WriteLine($"Deconstruction of person. Name: {name}, Age: {age}");

Person person1 = new Person("Bob", 16);
Console.WriteLine(person1);

Point point = new Point(3, 4);
Console.WriteLine($"Point({point.X}, {point.Y}) Distance to origin: {point.DistanceToOrigin()}");
//point.X = 11; // Помилка: не можна змінювати поле readonly struct

Point point2 = point;
Console.WriteLine($"Point2 is copy of point1 ({point2.X}, {point2.Y}) Distance to origin: {point2.DistanceToOrigin()}");
Console.WriteLine();

//person1 = null; // помилка: struct (value-type), тому не може бути null

// in, ref, out параметри для struct
// структури у функції передаються за значенням (копіюються) за замовчуванням
void DisplayPerson(in Person p) // in - передача за посиланням (швидко), але тільки для читання
{
    Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
}
void ChangeAge(Person p) // якщо потрібно змінити структуру, то передаємо її за посиланням ref
{
    ++p.Age;
}
// struct - тип-значення (value-type), зберігається на стеку (якщо не є частиною класу)
struct Person
{
    public string Name { get; set; } = "Noname";
    public int Age;

    public Person()
    {
        //Name = "Default person";
        //Age = 17;
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Deconstruct(out string name, out int age) // метод розпакування об'єкта на окремі змінні (частини)
    {
        name = Name;
        age = Age;
    }
    override public string ToString() // можна перевизначити метод ToString() у struct
    {
        return $"Person(Name: {Name}, Age: {Age})";
    }
}
readonly struct Point // readonly struct - всі поля є readonly, тобто методи не можуть змінювати стан структури
{
    public readonly int X { get;}
    public readonly int Y { get; }
    public Point(int x, int y)
    {
        X = x;
        //++X; // дозволено в конструкторі
        Y = y;
    }
    public double DistanceToOrigin()
    {
        ++X; // Помилка: не можна змінювати поле readonly struct
        return Math.Sqrt(X * X + Y * Y);
    }
}