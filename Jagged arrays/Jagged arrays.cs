// See https://aka.ms/new-console-template for more information
Console.WriteLine("___Jagged arrays___ ");

int[][] jaggedArray = new int[3][]; // оголошення зубчастого масиву з 3 рядками
                                    // jaggedArray ---> [ null] [null ] [null ]
jaggedArray[0] = new int[2] { 1, 2 };       // перший рядок з 2 елементами
jaggedArray[1] = new int[4] { 3, 4, 5, 6 }; // другий рядок з 4 елементами
jaggedArray[2] = new int[3] { 7, 8, 9 };    // третій рядок з 3 елементами
                                            // jaggedArray ---> [ 1, 2 ] [3, 4, 5, 6 ] [7, 8, 9 ]

PrintJaggedArray(jaggedArray);

void PrintJaggedArray(int[][] jaggedArray)
{
    for (int i = 0; i < jaggedArray.Length; i++) // ітеруємося по рядках,  jaggedArray.Length - кількість рядків
    {
        Console.Write($"Row {i}: ");
        for (int j = 0; j < jaggedArray[i].Length; j++) // ітеруємося по елементах рядка,
                                                        // jaggedArray[i].Length - кількість елементів у рядку i
        {
            Console.Write(jaggedArray[i][j] + "\t");
        }
        Console.WriteLine();
    }
}