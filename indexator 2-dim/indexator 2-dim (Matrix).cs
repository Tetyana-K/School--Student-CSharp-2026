Matrix m = new Matrix(2, 3);
m[0,0] = 10;
m[1, 0] = 20;
m.Display();
//m[2, 3] = 77; // exception
class Matrix
{
    private int[,] matrix;
    public Matrix(int rows = 3, int cols = 3)
    {
        matrix = new int[rows, cols];
    }
    public int this[int r, int c] // двовимірний індексатор - властивість для роботи з об`єктом через індексування
    {
        get => matrix[r, c];
        set => matrix[r, c] = value;
    }
    public void Display()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],5}");
            }
            Console.WriteLine();
        }
    }
}