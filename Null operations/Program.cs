string str = "Demo  line";
Console.WriteLine($"String = '{str}'");
Console.WriteLine($"Length  = {str.Length}");
Console.WriteLine($"Substring(0, 4)  = {str.Substring(0, 4)}");

str = null;
Console.WriteLine($"\n\nString = '{str ?? "Notext"}'"); // ?? -  null coalescing
                                                        //Console.WriteLine($"Length  = {str.Length}"); // летить виняток, бо звертаємося через  null(об'єкта рядка немає)

Console.WriteLine($"Length  = {str?.Length}"); //?. null-conditional, якщо не null, то звертаємося до  властивості(методу), інакше поверне null
Console.WriteLine($"Length  = {str?.Length ?? -1}"); //?. null-conditional , якщо не null, то звертаємося до  властивості(методу), інакше поверне null
Console.WriteLine($"Substring(0, 4)  = '{str?.Substring(0, 4)}'");


int[] arr = { 10, 20, 30, 40, 50 }; // теж посилального типу, можна = null, arr ----> [10][20][30][40][50]
arr = null;
Console.WriteLine($"\nLength of array  = {arr?.Length}"); //?. null-conditional , якщо не null, то звертаємося до  властивості(методу), інакше поверне null
Console.WriteLine($"First element of array  = {arr?[0]}"); // індексування  з  перевіркою на null
Console.WriteLine($"First element of array__  = {arr?[0] ?? int.MinValue}"); // індексування  з  перевіркою на null


 //arr = new int[7];// arr----> [][][][][][]  в любому  випадку масив створюється новий
arr ??= new int[7];// arr----> [][][][][][]  масив створюється, якщо масиву не  було(тобто null)
Console.WriteLine($"\nNOW Length of array  = {arr?.Length}"); //?. null-conditional , якщо не null, то звертаємося до  властивості(методу), інакше поверне null
Console.WriteLine($"Array elements: {string.Join(", ", arr ?? new int[0])}");

// ! null-forgiving operator - оператор, що "примушує" компілятор вважати, що змінна не є null
string text = Console.ReadLine()!;
//text = null;
int length = text!.Length; // Використання null-forgiving operator
Console.WriteLine($"Length");

class Person
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value ?? "Noname"; }
    }
    public int Age;
}