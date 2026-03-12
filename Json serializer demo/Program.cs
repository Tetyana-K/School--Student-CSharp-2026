using Json_serializer_demo;
using Newtonsoft.Json; // через Nuget пакет Newtonsoft
using System.Text.Json;
using JsonText = System.Text.Json; // JsonText аліас простору імен System.Text.Json

//DemoJsonText();

// Demo  NewtonSoft
Car ford = new Car(555, "Ford", 4.1);

DemoNewtonsoftSerializer(ford);

static void DemoJsonText()
{
    int[] arr = { 10, 20, 30, 40, 50 };
    string jsonArr = JsonText.JsonSerializer.Serialize(arr);
    File.WriteAllText("../../../arr.json", jsonArr);
    Console.WriteLine($"Json from array :\n{jsonArr}");

    int[] darr = JsonText.JsonSerializer.Deserialize<int[]>(jsonArr);
    Console.WriteLine($"Deserialized array: {string.Join(" ", darr)}");

    Car ford = new Car(333, "Ford", 3.2);
    string json = JsonText.JsonSerializer.Serialize<Car>(ford);
    Console.WriteLine("\n_________Car ---> JSON___________");
    Console.WriteLine(json);

    string path = "../../../car.json";
    File.WriteAllText(path, json);

    // Car readCar = JsonSerializer.Deserialize<Car>(json);
    Car? readCar = JsonText.JsonSerializer.Deserialize<Car>(File.ReadAllText(path));
    Console.WriteLine("\n_________JSON ---> Car___________");
    Console.WriteLine(readCar);


    SortedList<int, Car> sl = new SortedList<int, Car>
    {
        [333] = ford,
        [200] = new Car(200, "Toyota", 4.2),
    };

    json = JsonText.JsonSerializer.Serialize<SortedList<int, Car>>(sl);
    Console.WriteLine("\n_________SortedList of Car ---> JSON___________");
    Console.WriteLine(json);

    var readCars = JsonText.JsonSerializer.Deserialize<SortedList<int, Car>>(json);
    Console.WriteLine("\n_________JSON ---> SortedList of Car___________");
    if (readCars == null)
    {
        Console.WriteLine("Error desirialization");
        return;
    }
    foreach (var c in readCars)
    {
        Console.WriteLine(c.Value);
        //Console.WriteLine(c);
    }
}

static void DemoNewtonsoftSerializer(Car car)
{
    string json = JsonConvert.SerializeObject(car);
    Console.WriteLine("_________Car ---> JSON___________");
    Console.WriteLine(json);

    Car? readCar = JsonConvert.DeserializeObject<Car>(json);
    Console.WriteLine("\n_________JSON ---> Car___________");
    Console.WriteLine(readCar);
}