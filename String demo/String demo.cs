// See https://aka.ms/new-console-template for more information
Console.WriteLine("----String demo----");
// String - послідовність символів у кодуванні UTF-16, string є посилальним типом (reference type) і є незмінним (immutable)
// String - це масив символів char під капотом,
// не змінюваний тип означає, що після створення об'єкта String його вміст не може бути змінений

string str1 = "Today we       have lesson!with      ,,,, topic 'Strings in C#'  D:\\MY\\my.cs";

string str2 = @"C# is modern programming language.
It is developed by Microsoft. D:\MY\my.cs";

Console.WriteLine(str1);
Console.WriteLine(str2);

Console.WriteLine($"Length = {str1.Length}");
//str1[0] = '+'; // помилка, оскільки String є незмінним типом
Console.WriteLine($"First char = {str1[0]}, Last char = {str1[str1.Length - 1]}");

// для посимвольного обходу та зміни рядка string можна сконвертувати його у масив символів char[]
char[] charArray = str1.ToCharArray();
charArray[0] = char.ToLower(str1[0]); // зміна першого символу на нижній регістр
Console.WriteLine($"\nResult = {new string(charArray)}");

// основні методи класу String
Console.WriteLine($"\nstr1 to upper: {str1.ToUpper()}"); // створюється НОВИЙ рядок у верхньому регістрі
Console.WriteLine($"\nstr2 to lower: {str2.ToLower()}");
Console.WriteLine(str1); // str1 залишається без змін !!!

Console.WriteLine($"\nAfter replace 'a' to '@' =  {str1.Replace('a', '@')}"); // створюється НОВИЙ рядок, у якому ВСІ 'a' замінені на '@', але ми його не зберігаємо
Console.WriteLine($"\nDelete start segment of string =  {str1.Remove(0, 5)}");

Console.WriteLine($"\nInsert substring into string =  {str1.Insert(0, "Hello! ")}");
//str1 = str1.Insert(0, "Hello! "); // збереження результату вставки у str1
Console.WriteLine($"\nSubstring from index 10, length 15 =  {str1.Substring(9, 16)}");
Console.WriteLine($"\nSubstring from index 10 to end of string =  {str1.Substring(9)}");

// пошукові методи
Console.WriteLine($"\nIndexOf 'lesson' in str1 = {str1.IndexOf("lesson")}");
Console.WriteLine($"\nLastIndexOf 'D' in str1 = {str1.LastIndexOf("D")}");
Console.WriteLine($"\nContains 'C#' in str1 = {str1.Contains("C#")}");
Console.WriteLine($"\nStartsWith 'Today' in str1 = {str1.StartsWith("Today")}");
Console.WriteLine($"\nEndsWith '.cs' in str1 = {str1.EndsWith(".cs")}");

var symbols = new char[] { '#', '\\', 'a' };
Console.WriteLine($"\nContains symbols '#', '\', 'a' in str1 = {str1.IndexOfAny(symbols)}");

// поділ рядка на підрядки
//string[] segments = str1.Split(' ', ',', '.', '!'); // розділення за пробілом, комою та крапкою
char[] separators = new char[] { ' ', ',', '!', '\'' };
string[] segments = str1.Split(separators, StringSplitOptions.RemoveEmptyEntries); // розділення за пробілом, комою та крапкою
foreach (var segment in segments)
{
    //if (!string.IsNullOrEmpty(segment)) // пропускаємо порожні підрядки
        Console.WriteLine($"Segment: {segment}");
}

// з'єднання підрядків у рядок
string joinedString = string.Join(" | ", segments);
Console.WriteLine($"\nJoined string: {joinedString}");

int[] arr = { 11, 22, 33, 44, 55 };
Console.WriteLine($"Array : {String.Join(", ", arr)}");

