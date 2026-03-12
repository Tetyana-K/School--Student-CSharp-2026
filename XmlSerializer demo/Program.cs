using System.Xml.Serialization;
using XmlSerializer_demo;

Car bmw = new Car(222, "Toyota", 4.3);
Console.WriteLine(bmw);

XmlSerializer xs = new XmlSerializer(typeof(Car)); // typeof(Car) -  для вказання якого типу обєкт серіалізуємо

XmlSerializer xs2 = new XmlSerializer(typeof(int[])); // typeof(Car) -  для вказання якого типу обєкт серіалізуємо

string path = "../../../car.xml";
using (StreamWriter sw = new StreamWriter(path))
{
    xs.Serialize(sw, bmw); // серіалізуємо обєкт bmw у потік, повязаний з файлом car.xml
}

using (StreamReader sr = new StreamReader(path))
{
    Car? car = xs.Deserialize(sr) as Car; // десеріалізуємо з потоку( файлу) у об'єкт
    Console.WriteLine("_______DESERIALIZED __ CAR______________\n");
    Console.WriteLine(car);
}
