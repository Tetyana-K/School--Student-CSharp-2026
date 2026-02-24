using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_class__Stack_
{
    internal class MyStack<T> : IMyStack<T>
    {
        const int defaultCapacity = 10; // константа для початкової ємності стеку
        const int emptyStack = -1; // константа для позначення порожнього стеку
        private T [] stack; // поле для зберігання елементів стеку
        int top;//= emptyStack; // індекс вершини стеку, ініціалізований значенням -1, що означає, що стек порожній
        public MyStack() 
        {
            top = emptyStack; // ініціалізація індексу вершини стеку значенням -1, що означає, що стек порожній
            stack = new T[defaultCapacity]; // створення масиву для зберігання елементів стеку з початковою ємністю 10
        }
        public bool IsEmpty()
        {
            return top == emptyStack; // стек порожній, якщо індекс вершини стеку дорівнює -1
        }

        public T Peek()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack[top];
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T item = stack[top];
            stack[top] = default(T); // очищення елемента для уникнення утримання посилань
            top--;
            return item;
        }
        

        public void Push(T item)
        {
            if(top == stack.Length - 1) // якщо стек заповнений, збільшуємо його ємність
            {
                Array.Resize(ref stack, stack.Length * 2); // подвоюємо розмір масиву
            }
            stack[++top] = item; // додаємо елемент на вершину стеку
        }
    }
}
