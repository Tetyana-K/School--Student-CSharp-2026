Person person = new Person();
//person.Name = "Alice";
//person.Age = 30;
Console.WriteLine(person.Name);
Console.WriteLine(person.Age);
struct Person
{
    public string Name { get; set; }= "Noname";
    public int Age = 33;

    public Person()
    {
        //Name = "AAA";
        //Age = 22;
    }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}