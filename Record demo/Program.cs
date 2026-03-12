Person p = new Person("Maria", 17);
Console.WriteLine(p);
//p.Name = "Olena"; // помилка компіляції


// record - тип посилання, але порівнюється як структури по контенту
record Person(string name, int age);
record Developer(string name, int age, string stack)
    : Person(name, age);