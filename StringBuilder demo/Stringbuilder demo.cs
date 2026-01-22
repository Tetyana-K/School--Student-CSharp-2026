// See https://aka.ms/new-console-template for more information
using System.Text; // StringBuilder

Console.WriteLine("___ StringBuilder_____");
StringBuilder sb = new StringBuilder("Hello", 100);
sb[0] = 'h';
Console.WriteLine(sb);
Console.WriteLine($"Capacity = {sb.Capacity}, Length = {sb.Length}");
sb.Append(", World!");
Console.WriteLine($"Capacity = {sb.Capacity}, Length = {sb.Length}");
sb.AppendLine();
sb.AppendFormat("Current Date and Time: {0}", DateTime.Now);
Console.WriteLine(sb);

Console.WriteLine($"Capacity = {sb.Capacity}, Length = {sb.Length}");
