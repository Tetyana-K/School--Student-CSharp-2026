// See https://aka.ms/new-console-template for more information
using Generic_class__Stack_;

Console.WriteLine("_____My  Generic Stack_____");
MyStack<int> stack = new MyStack<int>(); // stack of integers
stack.Push(1);
stack.Push(2);

Console.WriteLine($"After pushing 1 and 2: {stack.Peek()}");    

stack.Pop();