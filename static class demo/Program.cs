//GeometryUtils geo = new GeometryUtils(); // помилка: не можна створювати екземпляри статичних класів

var area = GeometryUtils.CalculateCircleArea(5.0);
Console.WriteLine($"Area of circle with radius 5.0 = {area:f2}");  
static class GeometryUtils
{
    //int id = 1; // помилка: не можна мати нестатичні поля в статичному класі
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }
}