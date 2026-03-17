// See https://aka.ms/new-console-template for more information
using Adapter;

Console.WriteLine("_______ADAPTER_________");
ICoffeeMachine coffeeMachine = new CoffeMachine();
coffeeMachine.MakeLatte();
coffeeMachine.MakePureCoffe();

