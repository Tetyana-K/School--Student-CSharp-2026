using Events_Demo;

Product tv = new Product { Name = "TV", Price = 20_000 };

Client petro = new Client { Name = "Petro" };
Client anna = new Client { Name = "Anna" };

// tv.PriceDown = petro.Handler; // compiler error для event, ніби підписужмо  Петра,  але відписуємо  інших
//tv.PriceDown = null; // compiler error для event, ніби відписуємо  усіх

tv.PriceDown += petro.Handler; // ок, дописали Петра
tv.PriceUp += petro.Handler; // ок, дописали Петра
tv.PriceDown += anna.Handler;

tv.Price = 21_000; // змінили ціну, ініціювали подію підвищення ціни, яка викликала методи обробки Петра 

tv.Price = 19_000; // змінили ціну, ініціювали подію зниження ціни, яка викликала методи обробки Петра і Анни

tv.PriceUp -= petro.Handler; // відписали Петра від події збільшення ціни
Console.WriteLine();
tv.Price = 18_000;