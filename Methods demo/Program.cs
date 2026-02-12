int a = 5;
int b = 10;
Console.WriteLine($"Before swap: a = {a}, b = {b}");
WrongSwap( a,  b);
Console.WriteLine($"After WrongSwap: a = {a}, b = {b}");

Swap(ref a, ref b); // при виклику функції Swap ми використовуємо ключове слово ref
Console.WriteLine($"After correct swap: a = {a}, b = {b}");

string str1 = "Hello";
string str2 = "World";
Console.WriteLine($"\nBefore generic swap: str1 = {str1}, str2 = {str2}");
//GenSwap<string>(ref str1, ref str2); // при виклику функції GenSwap ми використовуємо ключове слово ref
GenSwap(ref str1, ref str2); // при виклику функції GenSwap ми використовуємо ключове слово ref
Console.WriteLine($"After generic swap: str1 = {str1}, str2 = {str2}");

int s, p;
SumProduct(a, b, out s, out p); // при виклику функції SumProduct ми використовуємо ключове слово out
Console.WriteLine($"\nSum: {s}, Product: {p}");

SumProduct(a, b, out int sum, out int product); // при виклику функції SumProduct ми можемо оголосити змінні безпосередньо в аргументах
Console.WriteLine($"Sum: {sum}, Product: {product}"); 

//PrintNumber(in a); // при виклику функції PrintNumber можемо використовувати ключове слово in за бажанням
PrintNumber( a); // при виклику функції PrintNumber ми використовуємо ключове слово in
void WrongSwap( int x,  int y) // локальна функція, яка приймає два параметри, але вони є копіями змінних a і b,
                               // тому зміни в цій функції не впливають на a і b 
{
    int temp = x;
    x = y;
    y = temp;
}
// ref, out, in - ключові слова для передачі параметрів за посиланням,
// ref - дозволяє змінювати значення параметра всередині функції,
// і ці зміни будуть відображатися поза функцією,
// ref- параметр повинен бути ініціалізований до передачі у функцію
void Swap(ref int x, ref int y) // локальна функція, яка приймає два параметри за посиланням, 
                                        // тому зміни в цій функції впливають на a і b 
{
    int temp = x;
    x = y;
    y = temp;
}
// generic - аналог шаблонів у C++, дозволяє створювати методи та класи, які можуть працювати з будь-яким типом даних, забезпечуючи при цьому типову безпеку.
// generic method - це метод, який може працювати з різними типами даних, не вказуючи конкретний тип під час написання коду.
void GenSwap<T>(ref T x, ref T y)
{
    //T temp = x;
    var temp = x;
    x = y;
    y = temp;
}
// out - дозволяє повертати кілька значень з функції, використовуючи параметри,
// які НЕ ПОТРІБНО ініціалізувати до передачі у функцію,
void SumProduct(int a, int b, out int sum, out int product)
{
    //++sum; // помилка компіляції, оскільки параметр sum, бо out, не ініціалізований до використання
    sum = a + b;
    //++sum; // тепер sum ініціалізований, тому ми можемо його використовувати
    product = a * b;
}
// in - дозволяє передавати параметр за посиланням, але без можливості його змінювати всередині функції,
void PrintNumber(in int number) // const int & number - аналог в C++, дозволяє передавати параметр за посиланням, але без можливості його змінювати всередині функції
{
    //++number; // помилка компіляції, оскільки параметр number, бо in, є лише для читання и не може быть изменен внутри функции
    Console.WriteLine($"In PrintNumber() func = {number}");
}