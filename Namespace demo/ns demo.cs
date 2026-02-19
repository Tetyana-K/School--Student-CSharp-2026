using Mathematics;
using Mathematics.Equations; // пыдключили простір імен Equations, вкладений всередині Mathematics
//using Mathematics.Shape;
using Drawing;
Circle c = new() { Radius = 10 };
Console.WriteLine($"Area = {c.Area()}");

//Mathematics.Equations.Linear eq = new Linear();
Linear eq = new Linear();
Mathematics.Shapes.Square sq = new () { Side = 10};
Console.WriteLine(sq);

Square drawSq = new () { Side = 4 };
drawSq.Draw();

namespace Mathematics // визначили користувацький простір імен Mathematics
{
    class Circle
    {
        public double Radius { get; set; }
        public double Area() => Math.PI * Math.Pow(Radius, 2);
    }
    namespace Equations // вкладений простір імен Equations всередині Mathematics
    {
        class Linear { }
        class Quadratic { }
    }
    namespace Shape  // вкладений простір імен Shape всередині Mathematics
    {
        class Rectangle { }
    }
}

namespace Mathematics.Shapes // іншим способом (Mathematics.Shapes ) вкладений простір імен Shapes всередині Mathematics
{
    class Square 
    {
        public int Side { get; set; }
        public int Area => Side * Side; // get-only властивість для обчислення площі квадрата
        override public string ToString() => $"Square with side {Side}, area = {Area}";
    }
}
namespace Drawing
{
    class Square
    {
        public int Side { get; set; } = 5;
        public void Draw()
        {
            string line = new string('*', Side);
            for (int i = 0; i < Side; i++)
                Console.WriteLine(line);
        }
    }
}

