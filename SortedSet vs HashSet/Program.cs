using Product_NS;
// невпорядкована множина,  збережена як хеш таблиця, швидкий пошук до  елемента (пошук елемента на основі хеш, складність O(1))
HashSet<string> set = new HashSet<string>()
{
    "apple",
    "pear",
    "blueberry"
};

set.Remove("apple");
set.Add("blackberry");
Console.WriteLine("______Hash set_____");
foreach (var item in set)
{
    Console.WriteLine(item);
}
Console.WriteLine($"\nIs 'apple' in set? {set.Contains("apple")}");

//  впорядкована множина, збережена як дерево бінарного пошуку, швидкий пошук до  елемента (складність O(log n))

SortedSet<string> sortedSet = new SortedSet<string>(set); //
//    "apple",
//    "pear",
//    "blueberry"
//};
sortedSet.Add("banana");
sortedSet.Add("lemon");
Console.WriteLine("______Sorted set_____");
foreach (var item in sortedSet)
{
    Console.WriteLine(item);
}
Console.WriteLine($"\nIs 'lemon' in sorted set? {sortedSet.Contains("lemon")}");

HashSet<Product> products = new HashSet<Product>()
{
    new Product() { Name = "TV", Price = 1000 },
    new Product() { Name = "Phone", Price = 500 },
    new Product() { Name = "Laptop", Price = 1500 }
};
products.Add(new Product() { Name = "TV", Price = 1000 }); //  не додасться у products, оскільки об'єкт з такими ж даними вже існує, а ми перевизначили GetHashCode(), Equals() 
// якщо б ми не перевизначили GetHashCode(), Equals(), то додалося б, оскільки за замовчуванням ці методи працюють на основі посилання на об'єкт,
// і два різні об'єкти вважаються різними, навіть якщо їхні дані однакові
Console.WriteLine("______Products (hashset)_____");
foreach (var item in products)
{
    Console.WriteLine($"{item.Name} : {item.Price}");
}