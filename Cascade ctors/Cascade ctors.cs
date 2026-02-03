Animal a = new Animal("Snow");
a.Say();
a.Weight = 5.5;
a.Say();

Animal b = new Animal("Bella", 4, 2.3);
b.Say();

Animal c = new Animal("Jack");
c.Say();

Animal d = new Animal();
d.Say();

class Animal
{
    private string name;
    private int age;
    //private double weight;
    public double Weight { get; set; } // auto-property, компілятор генерує приховане поле для зберігання значення властивості
    // private double _weight; 
    public Animal(string name, int age, double weight)
    {
        this.name = name;
        this.age = age;
        this.Weight = weight;
    }
    public Animal() : this("NoName", 1, 3) // викликається к-тор з трьома параметрами ( головний )
    {
        
    }
    public Animal(string name) // к-р з 1 параметром (імя тваринки)
       // : this(name, 1, 3)                  // викликається к-тор з трьома параметрами ( головний )
       : this(name, 1) // викликається каскадно к-тор з двома параметрами
    {
        //this.name = name;
        //this.age = 1;
        //this.Weight = 3;
    }

    public Animal(string name, int age)
        : this(name, age, 3)                 // викликається к-тор з трьома параметрами ( головний )
    {
        //this.name = name;
        //this.age = age;
        //this.Weight = 3;
    }



    public void Say()
    {
        //Console.WriteLine("Hi! I'am an Animal. My name is '{0}', age = {1}, weight = {2}", this.name, this.age, this.weight);
        Console.WriteLine($"Hi! I'am an Animal. My name is '{name}', age = {age}, weight = {Weight}");
    }


}