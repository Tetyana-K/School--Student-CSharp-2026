// See https://aka.ms/new-console-template for more information
Console.WriteLine("_____________Multidimensional arrays_____");

int[,] matrix = new int[3, 4] // 3 рядки, 4 стовпці, двовимірний прямокутник масив
{
    {1, 2, 3, 4 },
    {5, 6, 7, 8 },
    {9, 10, 11, 12 }
};
PrintMatrix(matrix);
Console.WriteLine();

PrintMatrixForeach(matrix);
Console.WriteLine($"Length = {matrix.Length}"); // 12 = 3*4 - загальна кількість елементів
Console.WriteLine($"Rank = {matrix.Rank}"); // 2 - кількість вимірів (вимірність)
Console.WriteLine($"GetLength(0) = rows  = {matrix.GetLength(0)}"); // 3 - кількість рядків, 0 - перший вимір
Console.WriteLine($"GetLength(1) = columns = {matrix.GetLength(1)}"); // 4 - кількість стовпців, 1 - другий вимір

void PrintMatrix(int[,] m)
{
    int rows = m.GetLength(0);
    int cols = m.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(m[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void PrintMatrixForeach(int[,] m)
{
    Console.WriteLine($"____Print Matrix by foreach");
    foreach (var item in m)
    {
        Console.Write(item + "\t");
    }
    Console.WriteLine();
}