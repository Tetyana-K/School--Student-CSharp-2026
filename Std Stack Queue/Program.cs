Console.WriteLine("______________Stack<int>_____");
Stack<int> stack = new Stack<int>(10);
stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine($"Peek : {stack.Peek()}");

Console.WriteLine($"Stack print (from top to bottom)");
foreach(int i in stack)
    Console.WriteLine(i);

Console.WriteLine($"Removed top element {stack.Pop()}");

Console.WriteLine($"Stack print (from top to bottom)");
foreach (int i in stack)
    Console.WriteLine(i);

Console.WriteLine("\n______________Queue <char>_____");
Queue <char> queue = new Queue<char>();
queue.Enqueue( 'a' );
queue.Enqueue( 'b' );
queue.Enqueue( 'c' );
queue.Enqueue( 'd' );
Console.WriteLine($"Queue print (from first to last)");
foreach (char c in queue)
    Console.WriteLine(c);

Console.WriteLine($"{queue.Dequeue()} dequeued");
//queue.Clear();

Console.WriteLine($"Peek (first element): {queue.Peek()}"); 
Console.WriteLine($"Peek (last element): {queue.Last()}"); 




