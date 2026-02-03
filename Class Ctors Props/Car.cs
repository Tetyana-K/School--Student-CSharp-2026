using System;

// маємо простір імен Class_Ctors_Props, у якому оголошено клас Car
namespace Class_Ctors_Props
{
    // наші класи за замовчуванням НЕЯВНО успадкують клас Object
    // public - доступний звідусіль
    /*internal*/ class Car // internal - доступний лише в межах поточного проекту
    {
        private const int minYear = 1900; // константа для мінімального року випуску автомобіля
        private string brand; // поле для зберігання марки автомобіля
        private int year; // поле для зберігання року випуску автомобіля
        public Car() // конструктор без параметрів = конструктор за замовчуванням
        {
            brand = "No brand"; // ініціалізація поля brand значенням "No brand"
            year = minYear; // ініціалізація поля year поточним роком
        }
        public Car(string brand, int year = 2000) // конструктор з 1-м параметром для ініціалізації марки автомобіля
        {
            this.brand = brand; // використання this для посилання на поточний об'єкт
          //  this.year = year; // -33
            Year = year; // використання властивості Year для встановлення значення року випуску автомобіля з перевіркою
        }
        public void SetBrand(string brand) // метод для встановлення значення марки автомобіля
        {
            //if(!string.IsNullOrEmpty(brand))  // "" або null
            if (!string.IsNullOrWhiteSpace(brand)) // "  \t \n " null
                this.brand = brand; // використання this для посилання на поточний об'єкт
            // this.brand - поле класу
            // brand - параметр методу
        }
        public string GetBrand() // метод для отримання значення марки автомобіля
        {
            return brand; // повернення значення поля brand
        }
        // зробимо для поля year властивість Year з методами доступу get та set
        public int Year // full property - повна властивість, Поле + get set
        {
            //get { return year; }
            get => year; // скорочений запис для get
                         // set => year = (value >= minYear && value <= DateTime.Today.Year) ? value : minYear;
            set
            {
                if (value >= minYear && value <= DateTime.Today.Year)
                {
                    year = value;
                } // value - вбудоване ключове слово, яке представляє значення, що присвоюється властивості
            }
        }
        public override string ToString() // перевизначення методу ToString() з класу Object
        {
            return $"*** Car brand: {brand} Year {year}"; // повернення рядкового представлення об'єкта Car
        }

    }
}
