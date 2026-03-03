using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo;

class Client
{
    public string Name { get; set; }
    public void Handler(Product p, string message) // 4. Subscriber повинен метод  для обробки події, який підходить під  тип події  
    {
        Console.WriteLine($"Client {Name} notified about  change price of {p.Name}");
        Console.WriteLine($"\t\tNew price  = {p.Price}");
        Console.WriteLine($"\t\tAdd info  = {message}");
    }
}

