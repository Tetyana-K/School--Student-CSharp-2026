// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("___________PATTERN BUILDER  DEMO _______________");
CarBuilder carBuilder = new CarBuilder();
Director director = new Director(carBuilder);
director.MakeSportCar();

Car car = carBuilder.GetResult();
Console.WriteLine(car);

Console.WriteLine();

director.MakeSUVCar();
Car  car2 = carBuilder.GetResult();
Console.WriteLine(car2);

ManualBuilder manualBuilder = new ManualBuilder();
director.SetBuilder(manualBuilder);
director.MakeSportCar();
Manual manual = manualBuilder.GetResult();
Console.WriteLine($"Manual :\n{manual.Info}");




