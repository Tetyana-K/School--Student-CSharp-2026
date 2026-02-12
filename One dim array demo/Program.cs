int[] arr = { 10, 20, 30, 40, 50, 60, 70 }; // оголошення та ініціалізація масиву з 7 елементами
                                            // arr(stack) ---> [ 10 ] [ 20 ] [ 30 ] [40] [][][70] (heap)
int[] b = arr; // копіювання посилання, // arr, b(stack) ---> [ 10 ] [ 20 ] [ 30 ] [40] [][][70] (heap)

// Усі масиви неявно успадковані від абстрактного базового класу System.Array,
// який надає багато корисних методів і властивостей для роботи з масивами,
// таких як Length, CopyTo, Sort, Reverse та інші.

// Length - це властивість масиву, яка повертає кількість елементів у масиві
//Console.ForegroundColor = ConsoleColor.Blue; // set

Console.WriteLine($"Array length: {arr.Length}"); // виведення довжини масиву
//arr.Length = 5; // помилка компіляції, оскільки властивість Length є лише для читання (get), і її не можна змінювати

for (int i = 0; i < arr.Length; i++) // ітеруємося по елементам масиву за допомогою циклу for
{
    ++arr[i]; // збільшуємо значення кожного елемента масиву на 1
    Console.WriteLine($"Element {i}: {arr[i]}"); // виведення індексу та значення елемента масиву
}

foreach (int element in arr) // ітеруємося по елементам масиву за допомогою циклу foreach
{
    Console.Write($"{element, 7}|"); // виведення значення елемента масиву
}

Console.WriteLine($"\n\nEnter size of array:");
int size = int.Parse(Console.ReadLine()!); // зчитування розміру масиву з консолі
int[] arr2 = new int[size]; // оголошення та ініціалізація масиву з розміром, який вводить користувач
// arr2(stack) ---> [ 0 ] [ 0 ] [ 0 ] ... (heap) - всі елементи масиву ініціалізовані значенням за замовчуванням для типу int, тобто 0
PrintArray(arr2); // виклик локальної функції для виведення елементів масиву arr2
FillRandomArray(arr2, -10, 10); // виклик локальної функції для заповнення масиву arr2 випадковими числами в діапазоні від 1 до 100
PrintArray(arr2);
//arr2 = null;

int[] arr3 = (int[]) arr.Clone();
//int[] arr3 = arr.Clone() as int [];
PrintArray(arr3);
Console.WriteLine($"Reference equality arr and arr3: {ReferenceEquals(arr, arr3)}"); // false, оскільки arr і arr3 - це різні об'єкти в пам'яті

void PrintArray(int[] array) // локальна функція для виведення елементів масиву
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i], 7}");
    }
    Console.WriteLine();
}

void FillRandomArray(int[] array, int minValue = 0, int maxValue = 100) // локальна функція для заповнення масиву випадковими числами
{
    Random random = new Random(); // створення об'єкта Random для генерації випадкових чисел
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // заповнення елемента масиву випадковим числом в діапазоні від minValue до maxValue
    }
}