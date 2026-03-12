// Записи (records) - типи посилання, використовують для незмінних (immutable) об'єктів
// але порівнюється як структури по контенту


Person mykola = new Person("Mykola", 19);
Console.WriteLine(mykola); // Tostring() ...

Person person = new Person("Mykola", 19);
Console.WriteLine($"Equals)person, mykola) : {Equals(person, mykola)}"); // Equals() для записів працює, як для структур, тобто порівнює вміст 
Console.WriteLine($"person== mykola : {person == mykola}"); // == порівнює  вміст записів
Console.WriteLine($"\nPerson's name : {person.Name}");
Console.WriteLine($"Person's age : {person.Age}");

//person.Age = 20; // помилка, намагаємося змінити вік запису person

// Можна створити нову копію об'єкта з деякими зміненими полями за допомогою with:
Person newPerson = mykola with { Name = "Taras" };
Console.WriteLine($"newPerson : {newPerson}");

Developer dev = new Developer("Anton", 25, ".NET, Angular");
Console.WriteLine($"\nemp : {dev}");


Person[] people = { mykola, newPerson, dev };
foreach (var p in people)
{
Console.WriteLine(p.Name);
}

Company company = new Company() { Title = "SoftServe", Country = "Ukraine" };
company.Title = "SOFTSERVE"; // властивість Title має set
                            // company.Country = "UKRAINE";// помилка компіляції // властивість Title має init - тільки стартова ініціалізація
                             //Company company2 = new Company("a", "b");// 
Console.WriteLine($"\ncompany : {company}");


record Person(string Name, int Age);
// можна успадкуватися від Запису
record Developer(string Name, int Age, string Stack)
    : Person(Name, Age);



//щоб зробити record частково змінним, можна використовувати init
record Company
{
    public string? Title { get; set; }//init; }
    public string? Country { get; init; }
    //public Company(string title, string country) // можна визначити конструктор
    //{
    //    this.Title = title;
    //    this.Country = country;
    //}

}