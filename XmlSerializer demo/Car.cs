using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerializer_demo;

// Xml serialzer
// 1) клас має бути відкритим
// 2) клас має  містити явний к-р без  параметрів
// 3) зможе серіалузвати ВІДКРИТІ поля та властивості

public class Engine
{
    public double Power { get; set; }
    public Engine()
        : this(1.0)
    {

    }
    public Engine(double power)
    {
        Power = power;
    }
    public override string ToString()
    {
        return $"Engine power : {Power}";
    }
}

public class Car
{
    private int id = -1; // приватні поля НЕ серіалізуються 

    //  [XmlIgnore()] // ігнорувати збереження цього property у xml
    //[XmlElement("Number")]
    //[XmlAttribute("Number")]
    //public int Id { get => id; set => id = value; }
    private string brand = "Unknown";
    public Car()
        : this(0, "Nobrand", 1.0)
    {

    }
    public Car(int id, string brand, double power)
    {
        Brand = brand;
        Engine = new Engine(power);
        this.id = id;
    }
    public string Brand { get => brand; set => brand = value ?? "Nobrand"; }
    //[XmlElement("EngineSuper")]
    public Engine Engine { get; set; }
    public override string ToString()
    {
        return $"Id {id}.\tCar brand {Brand ?? "NoBrand"}.\t{Engine}.";
    }
}



