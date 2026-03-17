using Strategy;

class Program
{
    enum TypeStrategy { Road = 1, Walking, Transport, Exit }; // enum - тип переліку, для меню
    static void Main()
    {
        Console.WriteLine("_" +
        "_________STRATEGY_______");
        Navigator navigator = new Navigator(); // створили об'єкт Навігатора
        TypeStrategy strategy;
        do
        {
            Console.WriteLine($"\t\tRoad = 1, Walking = 2, Transport = 3, Exit = 4");
            Console.WriteLine("\t\tChoose strategy : ");
             strategy = Enum.Parse<TypeStrategy>(Console.ReadLine()!);
            switch (strategy)
            {
                case TypeStrategy.Road:
                    navigator.SetStrategy(new RoadStrategy()); // налаштовуємо Навігатор на стратегію  Дорога
                    break;
                case TypeStrategy.Walking:
                    navigator.SetStrategy(new WalkingStrategy()); // налаштовуємо Навігатор на стратегію  Пішохід
                    break;
                case TypeStrategy.Transport:
                    navigator.SetStrategy(new PublicTransportStrategy()); // налаштовуємо Навігатор на стратегію  Рублічний Транспорт
                    break;
                case TypeStrategy.Exit:
                    Console.WriteLine("Bye!!!");
                    continue;
                    //break;
                default:
                    Console.WriteLine("Error strategy");
                    continue;
                    //break;
            }

            string from, to;

            Console.WriteLine("\t\tEnter point from : ");
            from = Console.ReadLine()!;

            Console.WriteLine("\t\tEnter point to : ");
            to = Console.ReadLine()!;
            
            navigator.BuildRoute(from, to);

        } while (strategy!= TypeStrategy.Exit);

    }

}
