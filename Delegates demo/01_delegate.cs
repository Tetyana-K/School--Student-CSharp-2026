// делегат = тип-посилання
// визначили тип делегату, який може посилатися на ф-ї виду void fff(string)

delegate void MyDeleg(string str); // за кадром створиться клас, який інкапсулює  у собі посилання на метод(групу методів) 
class Greeting
{
    public static void Hello(string name)
    {
        Console.WriteLine($"Hello  {name}!");
    }
    public static void Bye(string name)
    {
        Console.WriteLine($"Bye  {name}!");
    }

}
class Chat
{
    public string First { get; set; } = "First";
    public string Second { get; set; } = "Second";

    public void SendMessage(string message)
    {
        Console.WriteLine($"{First} sends {Second} : '{message}'");
    }
    public void SendMessageAnswer(string message)
    {
        Console.WriteLine($"{Second} answers {First} : '{message}'");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //MyDeleg? del = new MyDeleg(Greeting.Hello); // del ------> Greeting.Hello
        MyDeleg? del = Greeting.Hello; // неявне створення екземпляру делегата, який посилається на метод Greeting.Hello
       // Action<string> del = Greeting.Hello;

        Console.WriteLine($"\t\tMethod : {del.Method}");
       
        del("Vadym"); //неявний виклик метод у через  делегат, фактично  працює Hello("Vadym")
        del.Invoke("Vadym"); // те саме
        
        del = Greeting.Bye; // del ------> Greeting.Bye
        Console.WriteLine($"\t\tMethod : {del.Method}");
        del("Vadym"); // Bye("Vadym")

        del = HowAreYou; // del ------> HowAreYou (local function)
        del("Vadym");

        Chat chatGirls = new Chat { First = "Anna", Second = "Maria" };
        Chat chatBoys = new Chat { First = "Oleh", Second = "Sergii" };

        Console.WriteLine();
        del = chatBoys.SendMessage; // del ------> chatBoys.SendMessage
        del("Lets play football");

        del = null;
       // del("TEST"); // NullReferenceException, оскільки del є null і не можна викликати метод через null-посилання
        del?.Invoke("Lets go to the cinema");//  del?.Invoke -  перевірка на null
        Console.WriteLine();

        del = chatBoys.SendMessage; // del ------> chatBoys.SendMessage
        del += chatBoys.SendMessageAnswer; // додали новий метод  у груповий делегат
        
        del += chatGirls.SendMessage; // додали новий метод  у груповий делегат
        del += chatGirls.SendMessageAnswer; // додали новий метод  у груповий делегат

        del?.Invoke("TEST");

        string[] messages = { "Hi!", "I am glad to  see you", "Hello!", "How  are you" };
        int i = 0;
        foreach (Delegate d in del!.GetInvocationList()) // ! - оператор null-forgiving, який повідомляє компілятору, що del не є null, і дозволяє викликати метод GetInvocationList() без попередньої перевірки на null.
        {
            d.DynamicInvoke(messages[i]);
            ++i;
        }

        del.GetInvocationList()[0].DynamicInvoke("Bye!!!");

        void HowAreYou(string name)
        {
            Console.WriteLine($"How are you {name}?");
        }
    }
}
