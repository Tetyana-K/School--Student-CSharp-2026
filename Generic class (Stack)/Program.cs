// See https://aka.ms/new-console-template for more information
using Generic_class__Stack_;

Console.WriteLine("_____My  Generic Stack_____");
MyStack<int> stack = new MyStack<int>(); // stack of integers
stack.Push(1);
stack.Push(2);

Console.WriteLine($"After pushing 1 and 2: {stack.Peek()}");

// Print stack elements using foreach loop
Console.WriteLine("Printing stack elements:");
foreach (var item in stack)
{
    Console.WriteLine(item); // 2, 1
}

stack.Pop();
//stack.Pop();
//stack.Pop();