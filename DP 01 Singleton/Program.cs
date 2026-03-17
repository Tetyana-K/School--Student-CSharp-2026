// See https://aka.ms/new-console-template for more information
using Singleton;

//FamilyBudget b = new FamilyBudget(12000);

Console.WriteLine("Singleton");

FamilyBudget father= FamilyBudget.GetBudget(20_000);
father.Add(2_000); // 22 000
father.Spend(5_000);// 17 000

Console.WriteLine();

FamilyBudget mother = FamilyBudget.GetBudget(200_000);// 17 000
mother.Add(1_000); // 18 000
mother.Spend(2_000);// 16 000

Console.WriteLine($"father ref equals mother : {ReferenceEquals(father, mother)}"); // true


