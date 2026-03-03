Action a = Hello; // a - посилається на локальну ф-ю Hello
a();

// a2 - посилається на лямбда- ф-ю 
Action<int, string> a2 = (int i, string s) => Console.WriteLine($"Number = {i}, String  ='{s}'");
a2(100, "Demo line");

Func<int, int, double> div = Div;
int c = 12, b = 5;
Console.WriteLine($"\n{c}/ {b} = {div(c, b)}");

Predicate<int> even = (int val) => val % 2 == 0;
Console.WriteLine($"Is even {c} = {even(c)}");
Console.WriteLine($"Is even {b} = {even(b)}");

void Hello()
{
    Console.WriteLine("Hello Action!");
}

static double Div(int a, int b) => (double)a / b;