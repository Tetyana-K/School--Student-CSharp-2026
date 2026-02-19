
Genre myFavoriteGenre = Genre.Comedy;
Console.WriteLine($"My favorite genre is: {myFavoriteGenre}, code in enum = {(int)myFavoriteGenre} ");

// Enum - базовий тип для усіх enum
var genres = Enum.GetValues<Genre>(); // отримуємо всі значення enum як масив
foreach (var genre in genres)
{
    Console.WriteLine($"Genre: {genre}, code in enum = {(int)genre} ");
}

string genreList = string.Join(", ", genres);
Console.WriteLine(genreList);

Console.WriteLine($"\nInput genre {genreList}: ");
string inputGenre = Console.ReadLine()!;

if (Enum.TryParse<Genre>(inputGenre, true, out Genre parsedGenre)) // true - ігноруємо регістр символів при парсингу
{
    Console.WriteLine($"You have selected: {parsedGenre}, code in enum = {(int)parsedGenre} ");
   // if (Enum.IsDefined(typeof(Genre), parsedGenre)) // перевіряємо, чи є значення визначеним у enum - посилена перевірка
    if (Enum.IsDefined<Genre>( parsedGenre)) // перевіряємо, чи є значення визначеним у enum - посилена перевірка
    {
        Console.WriteLine($"{parsedGenre} is a defined genre in the enum.");
    }
    else
    {
        Console.WriteLine($"{parsedGenre} is not a defined genre in the enum.");
    }
}
else
{
    Console.WriteLine($"'{inputGenre}' is not a valid genre.");
}

Material itemMaterials = Material.Wood | Material.Metal | Material.Fabric;
Console.WriteLine($"\nItem's material: {itemMaterials}, total enum value = {(int)itemMaterials}"); // приведення до int виведе суму значень прапорців

string[] materialNames = Enum.GetNames<Material>(); // отримуємо всі імена матеріалів як масив рядків
Console.WriteLine($"Input material: {string.Join(", ", materialNames)}");
string materialInput = Console.ReadLine()!;
if(Enum.TryParse<Material>(materialInput, true, out Material parsedMaterials))
{
    Console.WriteLine($"You have selected materials: {parsedMaterials}, {(int)parsedMaterials}");
}
else
{
    Console.WriteLine($"'{materialInput}' is not a valid material combination.");
}

// enum - перелічуваний тип
// enum - це тип даних, який складається з набору іменованих констант, які представляють цілі числа.
// усі enum-типи успадковуються від базового типу System.Enum, який є абстрактним класом,
// що надає загальні методи для роботи з enum-типами, такі як GetValues(), GetNames(), TryParse() та інші.
enum Genre //: byte // базовий тип byte 0..255, по замовчуванню базовий тип enum - int
{
    Action , // 0 за замовчуванням
    Comedy , // +1 відносно попереднього, якщо не вказано явно
    Drama , //2
    Horror, //3
    Romance, //4
    SciFi //5
}

[Flags] // атрибут, що вказує, що enum є прапорцевим (bit field), 
// тобто кожне значення enum є степенем двійки,
// що дозволяє комбінувати їх за допомогою побітових операцій
enum Material // прапорцевий enum
{
    None = 0, // 00000000
    Wood = 1 << 0, // 1     00000001
    Metal = 1 << 1, // 2    00000010
    Plastic = 1 << 2, // 4  00000100
    Glass = 1 << 3, // 8    00001000
    Fabric = 1 << 4 // 16   00010000
                    // можна комбінувати значення
                    // наприклад, Wood | Metal = 00000011 = 3
}
