using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
// LINQ =  Language Integrated Query
// Linq To  Objects - для опрацювання (вибірки, впорядкування) послідовносты даних  однакового типу
// IEnumerable <T>
// Можна формувати запити у двох формах
//1)  декларативно, схоже на запит SQL ( from m in movies)
//2)  метод розширення  movies.Where(x=>x......)


namespace Linq_To_Objects
{
    [Flags]
    enum Genre { Action = 1, Fantasy = 2, Comedy = 4, Drama = 8 }
    class Movie
    {
        public string? Name { get; set; }
        public Genre Genre { get; set; }
        public int Year { get; set; }
        public override string ToString()
        {
            return $"{Name,-20} {Genre,-12} {Year,-10}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 27, 2, 77, -157 };//, 3, 1, 1, 2, -1 };
            int[] b = { 1, 2, 2, -1, 5, 7, 0 };

            // 1 спосіб - у вигляді запиту from el in a 
            // where дозволяє визначити умову відбору елементів
            // select -  оператор виконує проєкцію на колекцію, щоб отримати необхідні члени (частини чи комбінації) елементів


            var even =  from el in a  
                        where el % 2 ==0 
                        select el;
            Print(a, "First array a:");
            Print(even, "Even numbers from first array a:");

            
            string[] food = { "apple", "pizza", "soup", "ice-cream", "juice" };
            // 1 спосіб запит Linq 
            var result = from f in food
                         orderby f // впорядкування по зростанню
                         select f;
            Print(result, "All food sorted asc :");

            var resultA = from f in food
                          where f.Contains('a')
                          orderby f descending
                          select f;
            Print(resultA, "Food with'a' sorted desc :");

            var biggerThan10 = from x in a where x > 10 select x;
            Console.WriteLine(string.Join("\t", biggerThan10));

            // 2 спосіб - методи розширення Where(), OrderBy(), Select()
            var lastDigit7 = a.Where(x => int.Abs(x) % 10 == 7).OrderByDescending(x=>x);
            Print(lastDigit7, "Last digit 7:");
            
            var union = a.Union(b);
            var intersect = a.Intersect(b);
            var dif = a.Except(b);

            Print(union, "Union a and b arrays");
            Print(intersect, "Intersect a and b arrays");
            Print(dif, "Difference a an b arrays");

            
            int sum = a.Sum();
            double avg = a.Average();
            int product = a.Aggregate((x, y) => x * y);
            int count = a.Count(x => x % 2 == 0);

            var part = b.OrderByDescending(x => x).Skip(2).Take(3);
            Console.WriteLine(string.Join("\t", part));
            Console.WriteLine(b.FirstOrDefault(x => x > 0));

            // 2  метод розширення  movies.Where(x=>x......)
            string[] lines = { "program", "C++", "C#", "database", "MS SQL Server" };

            char letter = 'a';
            var containsLetter = lines.Where(x => x.Contains(letter)); // поверне  IEnumerable <string> із  рядків, що  містять задану букву
            Print(containsLetter, $"Contains letter '{letter}'");

            //var sorteDesc = lines.OrderBy(x => x.Length);
            var sorteDesc = lines.OrderByDescending(x => x.Length);
            Print(sorteDesc, $"Sorted word list by  length desc");

            Console.WriteLine($"\n\nAverage length of line = {lines.Average(x => x.Length)}"); // середня довжина рядка у масиві

            Console.ReadKey();
            Console.Clear();

            List<Movie> movies = new List<Movie>()
            {
                new Movie{Name = "Terminator", Year = 1984, Genre=Genre.Action },
                new Movie{Name = "Titanik", Year = 1996, Genre=Genre.Drama },
                new Movie{Name = "Matrix", Year = 1999, Genre=Genre.Action | Genre.Fantasy },
                new Movie{Name = "Alient", Year = 1979, Genre=Genre.Fantasy }
            };

            List<Movie> movies2 = new List<Movie>()
            {
                new Movie{Name = "Terminator", Year = 1984, Genre=Genre.Action },
                new Movie{Name = "Titanik", Year = 1996, Genre=Genre.Drama },
                new Movie{Name = "Matrix2", Year = 1999, Genre=Genre.Action | Genre.Fantasy },
                new Movie{Name = "Alient2", Year = 1979, Genre=Genre.Fantasy }
            };

            //var re = movies.IntersectBy(movies2.Select(x=>x.Name), x=>x.Name);
            //Console.WriteLine(string.Join("\n", re));
                              

            Console.WriteLine($"\n\nAverage year = {movies.Average(m => m.Year)}"); // середній рік фільмів

            //1 спосіб  запит Linq from f in movies
            Genre genre = Genre.Action;
            var movieByGenre = from m in movies
                               where m.Genre.HasFlag(genre)
                               orderby m.Name //descending
                                              //select m.Name;
                               select m;
            Print(movieByGenre, $"Movies of genre");


        }
        static void Print<T>(IEnumerable<T> list, string text = "")
        {
            Console.WriteLine();
            Console.WriteLine(text);
            foreach (var item in list)
            {
                Console.WriteLine($"\t\t{item}");
            }
        }
    }
}

