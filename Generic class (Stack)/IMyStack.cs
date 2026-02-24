using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class__Stack_
{
    internal interface IMyStack <T> // узагальнений інтерфейс для стеку, який може працювати з будь-яким типом даних (T - це параметр типу, який буде замінений конкретним типом при реалізації інтерфейсу)
    {
        void Push(T item); // метод для додавання елемента на вершину стеку
        T Pop(); // метод для видалення та повернення елемента з вершини стеку
        T Peek(); // метод для повернення елемента з вершини стеку без його видалення
        bool IsEmpty(); // метод для перевірки, чи є стек порожнім
    }
}
