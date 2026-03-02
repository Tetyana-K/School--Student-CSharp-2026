
Console.WriteLine("------Generics-------");
int one = 10, two = 22;
//Swap(ref one, ref two);
Console.WriteLine($"one = {one}, two = {two}");
Console.WriteLine($"\nMax({one}, {two}) = {Maximum(one, two)}");


double oneD = 10.5, twoD = -2.2;
//Swap(ref oneD, ref twoD);

Console.WriteLine($"oneD = {oneD}, twoD = {twoD}");
Console.WriteLine($"\nMax({oneD}, {twoD}) = {Maximum(oneD, twoD)}");

string str1 = "First", str2 = "Second", str3 = "first";
//Swap(ref str1, ref str2);
Console.WriteLine($"str1 = {str1}, str2 = {str2}");
Console.WriteLine($"\nMax({str1}, {str2}) = {Maximum(str1, str2)}"); // "Second"
Console.WriteLine($"\nMax({str1}, {str3}) = {Maximum(str1, str3)}"); // "First" ?? 

Person anton = new Person() { Name = "Anton", Age = 19 };
Person lora = new Person() { Name = "Lora", Age = 21 };
Console.WriteLine($"\nMax({anton}, {lora}) = {Maximum(anton, lora)}"); // Lora, бо вона старша


//Console.WriteLine($"str1.CompareTo(str3) = {str1.CompareTo(str3)}"); // 0 equals string
//Console.WriteLine($"str1.CompareTo(str2) = {str1.CompareTo(str2)}"); // <0 
//Console.WriteLine($"str2.CompareTo(str1) = {str2.CompareTo(str1)}"); // >0 
// generic локальна функція
void Swap<T>(ref T a, ref T b) // ref - передача по посиланню, щоб змінити значення змінних, які передаються в метод
{
    var temp = a;
    a = b;
    b = temp;
}

//int Max(int a, int b)
//{
//    if (a > b)
//        return a;
//    return b;
//}
// where = constraints for Type = обмеження для типу, щоб вказати,
// які типи можуть бути використані з узагальненими класами та методами.
// T: struct - обмеження для типу T, щоб він був структурою (value type), а не класом (reference type).
// T: class - обмеження для типу T, щоб він був класом (reference type)
// T: IComparable<T> - обмеження для типу T, щоб він реалізував інтерфейс IComparable<T>, що дозволяє порівнювати об'єкти цього типу між собою.
T Maximum<T>(T a, T b) where T : /*struct */IComparable<T> // class T - ref type, struct  T - value type
{
    //if (a > b) //-- error
    if (a.CompareTo(b) > 0) // лоічно працює як порівняння операцією > 
        return a;
    return b;
}

class Person : IComparable<Person> // Person реалізує інтерфейс IComparable<Person>, щоб можна було порівнювати об'єкти через метод CompareTo
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person? other)
    {
        if (other == null) 
            return 1;
        return Age.CompareTo(other.Age);
    }
    public override string ToString()
    {
        return $"{Name} : {Age}";
    }
}