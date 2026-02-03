using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_demo
{
    internal class Employee
    {
        private static int counter; // приватне статичне поле для зберігання лічильника працівників
        // статичне поле - спільне для всіх об'єктів класу Employee
       // public int Id { get; private set; } // авто-властивість для зберігання ідентифікатора працівника
       
        public readonly int Id ; // поле лише для читання для зберігання ідентифікатора працівника
        // readonly поле може бути ініціалізоване лише під час оголошення або в конструкторі класу
        public string Name { get; set; } // авто-властивість для зберігання імені працівника
        public double Salary { get; set; } // авто-властивість для зберігання зарплати працівника

        public static int Counter // статична властивість для отримання значення лічильника працівників
        {
            get =>  counter;  // повернення значення лічильника працівників, скорочена форма запису через =>
        }
        public Employee()
        {
            Id = ++counter; // збільшення лічильника працівників при створенні нового об'єкта
                            // і присвоєння значення лічильника як ід працівника
        }

        override public string ToString()
        {
            return $"Id={Id}, Name={Name}, Salary={Salary}";
        }
    }
}
