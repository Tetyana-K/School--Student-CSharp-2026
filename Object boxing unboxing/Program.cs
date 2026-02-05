//Object // базовий  тип для усіх  типів у NET
int number = 123; // value-type змінна, зберігається на СТЕКУ   number :[123]

// object = class = ref type, має  зберігатися у дин памяті (HEAP)
object o = number; // упаковка(boxing), значення number(value-type) буде копіювати у НОВУ ділянку на HEAP  
Console.WriteLine($"_____Boxing int o = {o}, type = {o.GetType()} ");

// розпаковка(unboxing), object ---> створити ділянку на стеку та скопіювати значення ділянки на heap
int number2 = (int)o; // розпаковка виклнується через  явне зведення до потрібного типу,
                      // якщо тип не співпадає, то буде виняток InvalidCastException
Console.WriteLine($"Unboxing into number 2 = {number2,-10}");

o = 3.4; // boxing
Console.WriteLine($"\n_____Boxing  double o = {o}, type = {o.GetType()} ");

o = "Hello"; // немає  упаковки, копіюється посилання
Console.WriteLine($"\n______String to object(noboxing) o = {o}, type = {o.GetType()} ");
string str = (string)o;
Console.WriteLine($"Recovered string = {str}");
Console.WriteLine();

Console.WriteLine("___________Object type check");
CheckType(100);
CheckTypeWithIs(5.77);
CheckTypeWithSwitch("NET");
CheckTypeWithSwitch(true);

object[] arr = { 10, 2.3, "C++", "C#", true, false, 100, 4.5 };

static void CheckType(object obj)
{
    // obj.GetType() - повертає обєкт типу Type з  інформацієб про  тип  obj
    // typeof(int) - повертає обєкт типу Type з  інформацією про  тип  int
    if (obj.GetType() == typeof(int))                //перевірка чи прийшов int
    {
        int value = (int)obj; // unboxing
        Console.WriteLine($"Int ::: {value}");
    }
    else if (obj.GetType() == typeof(double))                //перевірка чи прийшов int
    {
        var value = (double)obj; // unboxing
        Console.WriteLine($"double ::: {value}");
    }
    else if (obj.GetType() == typeof(string))
    {
        var value = (string)obj;// recovering
        Console.WriteLine($"string ::: {value}");
    }
}
static void CheckTypeWithIs(object obj)
{
    // obj is type - перевірка чи у obj знаходиться обєкт типу type або похідний від нього(перевірка  чи представник типу type)
    if (obj is int)                //перевірка чи прийшов int
    {
        int value = (int)obj; // unboxing
        Console.WriteLine($"Int ::: {value}");
    }
    else if (obj is double)                //перевірка чи прийшов int
    {
        var value = (double)obj; // unboxing
        Console.WriteLine($"double ::: {value}");
    }
    else if (obj is string)
    {
        var value = (string)obj;// recovering
        Console.WriteLine($"string ::: {value}");

    }
}
static void CheckTypeWithSwitch(object obj)
{
    switch (obj)
    {
        case int value: // 1)  перевірка чи int 2) unboxing from obj into value 
            Console.WriteLine($"Int ::: {value}");
            break;
        case double value: // 1)  перевірка чи double 2) unboxing from obj into value 
            Console.WriteLine($"Double ::: {value}");
            break;
        case string value: // 1)  перевірка чи double 2) recovering from obj into value 
            Console.WriteLine($"String ::: {value}");
            break;

        default:
            Console.WriteLine($"Other type value :::: {obj}");
            break;
    }
}
