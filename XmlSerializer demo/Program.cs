using System.Xml.Serialization;
using XmlSerializer_demo;

Car bmw = new Car(222, "BMW", 4.3);
XmlSerializer xs = new XmlSerializer(typeof(Car)); // typeof(Car) -  для вказання якого типу обєкт серіалізуємо

string path = "../../../car.xml";
//using (StreamWriter sw = new StreamWriter(path))
//{
//    xs.Serialize(sw, bmw);
//}
using (StreamReader sr = new StreamReader(path))
{
    Car? car = xs.Deserialize(sr) as Car;
    Console.WriteLine("_______DESERIALIZED __ CAR______________\n");
    Console.WriteLine(car);
}
