using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Demo;

delegate void ProductHandler(Product p, string message); // 1. визначаємо тип делегата для події зміни ціни
class Product
{
    public event ProductHandler? PriceUp; // 2. визначили поле -подію(буде більш безпечний код) типу нашого делегату
    public event ProductHandler? PriceDown; // 2 визначили ще одну подію
    public string? Name { get; set; }

    private int price;
    public int Price
    {
        get => price;
        set
        { // частина  бізнес-логіки, де треба ініціювати подію 3) 
            if (value > price)
            {
                price = value;
                PriceUp?.Invoke(this, "Price changed ---  UP"); // 3. ініціювати подію  підвищення ціни
            }
            else if (value < price)
            {
                price = value;
                PriceDown?.Invoke(this, "Price changed ---  DOWN"); // 3. ініціювати подію  зниження ціни
            }
        }
    }
    public override string ToString()
    {
        return $"{Name,10} {Price,10}";
    }
}

