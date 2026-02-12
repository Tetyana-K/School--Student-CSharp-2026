Point p1 = new Point { X = 1, Y = 2 };
//p1.X = 10; // Зміна значення поля X у структурі Point

Console.WriteLine($"Point 1: X = {p1.X}, Y = {p1.Y}");
Point p2 = p1; // Копіювання значення p1 у p2 (створюється нова копія структури)    
Console.WriteLine($"Point 2: X = {p2.X}, Y = {p2.Y}");
p2.X = 5; // Зміна значення поля X у структурі p2
Console.WriteLine($"\nAfter p2.X = 5\n Point 1: X = {p1.X}, Y = {p1.Y}");
Console.WriteLine($"Point 2: X = {p2.X}, Y = {p2.Y}");
//p2 = null; // Помилка компіляції, оскільки структури є типами значень і не можуть бути null

Point3D point3D1 = new Point3D { X = 10, Y = 20, Z = 30 };
Point3D point3D2 = point3D1; // Копіювання посилання на об'єкт point3D1 у point3D2
                             // (обидві змінні посилаються на той самий об'єкт в пам'яті
point3D2.X = 50; // Зміна значення поля X у об'єкті, на який посилаються point3D1 і point3D2
Console.WriteLine($"\nAfter point3D2.X = 50\n Point3D1: X = {point3D1.X}, Y = {point3D1.Y}, Z = {point3D1.Z}");
Console.WriteLine($"Point3D2: X = {point3D2.X}, Y = {point3D2.Y}, Z = {point3D2.Z}");
point3D1 = null;

int[] arr = { 1, 2, 3 };
int[] arr2 = arr; // Копіювання посилання на масив arr
arr2[0] = 10; // Зміна значення першого елемента масиву через arr2
Console.WriteLine($"\nAfter arr2[0] = 10\narr: {string.Join(", ", arr)}");
Console.WriteLine($"arr2: {string.Join(", ", arr2)}");

struct Point // This is a value type
{
    public int X;
    public int Y;
}
class Point3D // This is a reference type
{
    public int X;
    public int Y;
    public int Z;
}
