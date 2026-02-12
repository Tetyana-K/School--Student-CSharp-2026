using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml;

Point point1 = new Point() { X = 1, Y = 2 };
Console.WriteLine(point1);

Point point2 = new Point() { X = 5, Y = 10 };
Console.WriteLine(point2);

Point point3 = point1 + point2; // тут викликається Point.operator +(point1, point2)
Console.WriteLine($"\n{point1} + {point2} = {point3}");

Point point4 = point1 * 10;
Console.WriteLine($"point4 = {point1} * 10 = {point4}");

++point4;
Console.WriteLine($"++ point4 = {point4}");
Console.WriteLine($"point4 ++ = {point4++}");
Console.WriteLine($"point4 = {point4} ");

Point point5 = new Point() { X = 5, Y = 10 }; // створили нову точку з такими координатиами як point2
Console.WriteLine($"point2 == point5 : {point2 == point5}"); // true
Console.WriteLine($"Hashcode point2 = {point2.GetHashCode()}, " +
    $"hash code point5 = {point5.GetHashCode()}");
Console.WriteLine($"point2 != point5 : {point2 != point5}"); // false
Console.WriteLine($"point1 != point5 : {point1 != point5}"); // true

Console.WriteLine($"\npoint2.Equals(point5) = {point2.Equals(point5)}");
Console.WriteLine($"{point1} < {point5} : {point1 < point5}");
//point2 = null;
//point1 = null;
Console.WriteLine(point1 == point2);

double value = point1; // implicit - неявне перетворення до типу double
Console.WriteLine($"double value = {value}");

int iValue = (int) point1; // explicit  - явне перетворення до типу int
Console.WriteLine($"int number = {iValue}");

Point point6 = (Point) 55; // explicit cast
Console.WriteLine($"point6 = (Point) 55 : {point6}");

point2[0] = 22; // point1.X = 22
point2[1] = 44; // point1.Y = 44
Console.WriteLine($"point2[0] = {point2[0]}, point2[1] =  {point2.Y}");

Console.WriteLine($"String index, point2[\"X\"] =  {point2["X"]}\n");

point1.X = 0;
point1.Y = 0;
if (point1)
{
    Console.WriteLine($"Point {point1} considered as true");
}
else
{ 
    Console.WriteLine($"Point {point1} considered as false");
}

// перевантаження функцій = однойменні функції з різним списком параметрів (різна сигнатура)
// перевантаження операторів (операцій) = можливість використання станд операції для користувацьких типів
// перевантажена операція у С# - відкрита статична функція
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public double Distance => Math.Sqrt(X * X + Y * Y); // властивість get (для читання)

    // indexator - властивість 
    public int this[int index]
    {
        get
        {
            if (index == 0)
                return X;
            if (index == 1)
                return Y;
            throw new IndexOutOfRangeException("Index can be 0 or 1");
        }
        set 
        {
            switch (index)
            {
                case 0: X = value; break;
                case 1: Y = value; break;
                default: throw new IndexOutOfRangeException("Index can be 0 or 1");
            }
        }
    }

    // індексатор для індекса- рядка, асоціативний індекс
    public int this[string ind]
    {
        get 
        {
            switch (ind.ToUpper())
            {
                case "X": return X;
                case "Y": return Y;
                default: throw new IndexOutOfRangeException("string index can be 'X', 'x', 'Y', 'y'");
            }
        }
    }
    public static Point operator +(Point left, Point right) // бінарний +
    {
        return new Point()
        {
            X = left.X + right.X,
            Y = left.Y + right.Y
        };
    }
    public static Point operator *(Point point, int number) // point1 * 3
    {
        Point result = new Point();
        result.X = point.X * number;
        result.Y = point.Y * number;
        return result;
    }
    // пишемо один раз ++, компілятор САМ зробить дві форми (префіксну та постфіксну)
    public static Point operator ++(Point point) // + 1 до кожної координати
    {
        return new Point()
        {
            X = point.X + 1,
            Y = point.Y + 1
        };
    }
    // деякі операції потрібно перевантажувати парами == !=, > <, >= <=, true false
    // рекомендовано при перевантаженні == також перевизначати метод Equals()
    public static bool operator ==(Point left, Point right)
    {
        //return left.X == right.X && left.Y == right.Y;
        if (ReferenceEquals(left, right)) // коли посилання однакові, то зліва та справи - один і той же обєкт
            return true;
        if (ReferenceEquals(left, null))
            return false;
        return left.Equals(right);

    }
    public static bool operator !=(Point left, Point right)
    {
        //return left.X != right.X || left.Y != right.Y; //можемо повністю писати потрібну логіку
        return !(left == right); // тут використовуємо раніше визначену операцію ==
    }

    public static bool operator >(Point left, Point right)
    {
        return left.X > right.X;
    }
    public static bool operator <(Point left, Point right)
    {
        return left.X < right.X;
    }

    // перевантажено оператор явного перетворення Point до типу int
    public static explicit operator int(Point point) 
    {
        return point.X;
    }
    // перевантажено оператор неявного перетворення Point до типу double
    public static implicit operator double(Point point)
    {
        return point.Distance;
    }
    public static explicit operator Point(int x)
    {
        return new Point() { X = x, Y = 0 };
    }
    public static bool operator true(Point point)
    {
        return point.X!=0 || point.Y !=0;
    }
    public static bool operator false(Point point)
    {
        return point.X == 0 && point.Y == 0;
    }
    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;
        if (obj is Point point)
        {
            return point.X == this.X && point.Y == this.Y;
        }
        return false;
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
        //return (X,Y).GetHashCode();
    }

    public override string ToString()
    {
        return $"({X}; {Y})";
    }
}
