using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_std__IComparable
{
    public class Device : IComparable, IComparable<Device>
    {
        public string Name { get; }
        public decimal Price { get; }

        public Device(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(Device? other)
        {
            //Console.WriteLine("\t\tCompareTo(Device) works");
            if (other == null)
                return 1;
            
            //return Name.CompareTo(other.Name); //порівнюємо за назвою
            return Price.CompareTo(other.Price); //порівнюємо за ціною
        }

        public override string ToString()
        {
            return $"{Name}  {Price}";
        }

        public int CompareTo(object? obj)
        {
            Console.WriteLine("\t\tCompareTo(object) works");
            if (obj == null)
                return 1;
            if (obj is Device otherDevice)
                return CompareTo(otherDevice);
            throw new ArgumentException("Object is not a Device");
        }
    }
}
// Створити клас Student (name, average score), який реалізує інтерфейс IComparable<Student>.
// Реалізувати метод CompareTo(Student other) так,
// щоб порівнювати студентів за їхнім середнім балом.
// Створити кілька об'єктів класу Student як масив або як список та відсортувати їх за допомогою методу Array.Sort() або List<T>.Sort().