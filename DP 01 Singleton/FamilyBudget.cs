using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class FamilyBudget
    {
        private int amount;
        private static FamilyBudget? instance; // 2. статичне поле з посиланням на єдиний екземпляр класу
        private FamilyBudget(int amount) // 1. private ctor
        {
            this.amount = amount;
        }
        public static FamilyBudget GetBudget(int amount = 0) // 3. метод доступу до єдиного екземпляру
        {
            if (instance == null) // ще обєкт не створений
            {
                instance = new FamilyBudget(amount);    // тоді створюємо об'єкт
            }
            else
            {
                if (amount > 0)
                {
                    instance.amount += amount;
                }
            }
            return instance; // повретаємо обєкт одинака
        }
        public void Add(int money)
        {
            amount += money;
            Console.WriteLine($"{money} was added to budget");
            Console.WriteLine($"Amount : {Amount}");
        }
        public int Amount => amount;

        public void Spend(int money)
        {
            if (money <= amount)
            {
                amount-=money;
                Console.WriteLine($"{money} were spent from budget");
                Console.WriteLine($"Amount : {Amount}");
            }
        }
        
    }
}
