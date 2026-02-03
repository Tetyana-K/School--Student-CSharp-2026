using Static_demo;


// створення об'єктів класу Employee через дефолтний конструктор з ІНІЦІАЛІЗАЦІЄЮ ВЛАСТИВОСТЕЙ
Console.WriteLine($"\tNumber of employees = {Employee.Counter}"); // 0 - ще немає працівників

Employee emp1 = new Employee() { Salary = 5000, Name = "John"  };
Console.WriteLine($"\tNumber of employees = {Employee.Counter}"); // 1 - створено першого працівника

Employee emp2 = new Employee() {  Name = "Jane", Salary = 6000 };
Console.WriteLine($"\tNumber of employees = {Employee.Counter}"); // 2 - створено другого працівника


Console.WriteLine(emp1); 
Console.WriteLine(emp2);

Employee [] group = new Employee[3]
{
    new Employee() { Name = "Bob", Salary = 5500 }, // counter = 3
    new Employee() { Name = "Alice", Salary = 7000 }, // counter = 4
    new Employee() { Name = "Tom", Salary = 4500 } // counter = 5
};

foreach (var emp in group)
    Console.WriteLine(emp);

Console.WriteLine($"\n\tNumber of employees = {Employee.Counter}"); // 5 - створено п'ять працівників

//emp1.Id = 5; // помилка у випадку звертання до readonly - поля
// намагаємося змінюємо ід першого працівника, але отримаємо помилку, бо властивість Id має приватний сеттер
Console.WriteLine(emp1);