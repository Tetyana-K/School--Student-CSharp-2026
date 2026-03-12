using System.Text.RegularExpressions;

Console.WriteLine("________________Regex demo");

// регулярні вирази - це шаблон для пошуку  в тексті, який описує  множину рядків,
// що відповідають цьому шаблону

string input = "My phone number is 123-456-7890.\nCall ME! Or call me 567-000-3334 or 111-222-5555999";
//string pattern = @"[0123456789]"; // шаблон для цифри
//string pattern = @"[1-5]"; // шаблон для цифр від 1 до 5
//string pattern = @"\d"; // шаблон для цифри
//string pattern = @"[^a-z]"; // шаблон для  не малої букви
//string pattern = @"\D"; // шаблон для  не цифри
//string pattern = @"\w"; // шаблон для word-символу (буква, цифра, _ )
//string path = @"d:\my\text\referat.docx";
//input.IndexOfAny("0123456789")

//string pattern = @"\d\d\d-\d\d\d-\d\d\d\d"; // шаблон для пошуку телефонного номера у форматі 123-456-7890
//string pattern = @"\d{3}-\d{3}-\d{4}"; // шаблон для пошуку телефонного номера у форматі 123-456-7890
string pattern = @"\b\d{3}-\d{3}-\d{4}\b"; // шаблон для пошуку телефонного номера у форматі 123-456-7890

//string pattern = "^[MC]"; 
//string pattern = "^[mc]"; 
//string pattern = "^[mc]"; 
//string pattern = "."; // . - довільнй символ
//string pattern = @"\."; // \. - крапка
//string pattern = @".$"; // любий символ, що завершує рядок   . 7

// Можна користуватися рег виразами двома способами
// 1) створюємо об'єкт рег виразу, використовуємо методи екземпляру 
// 2) використовуємо стат методи

Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline); // створили екземпляр класу Regex на рег виразі pattern

// match - співпадіння
// Match - клас, який описує співпадіння по рег виразу
// MatchCollection - клас колекції співпадіння

MatchCollection matches = regex.Matches(input); // шукаємо всі входження шаблону у рядку input,
                                                // результат - колекція з об'єктів Match, кожен з яких містить інформацію про знайдене входження шаблону
Console.WriteLine($"Pattern : {pattern}");

foreach (Match match in matches)
{
    Console.WriteLine($"Found match: {match.Value}, Index: {match.Index}");
}

pattern = @"call|me"; // | - логічне АБО, шукаємо або "call" або "me"
matches = Regex.Matches(input, pattern, RegexOptions.IgnoreCase /*| RegexOptions.Multiline*/);
Console.WriteLine($"\nPattern : {pattern}");
foreach (Match match in matches)
{
    Console.WriteLine($"Found match: {match.Value}, Index: {match.Index}");
}

//string inputEmail = "t_t@gmail.com"; // true
//string inputEmail = "t_@gmail.com"; // false, бо 3 символи має бути до @
string inputEmail = "My email : t_11@gmail.com"; // false, бо email має  займати весь рядок, а не бути його частиною

pattern = @"^\w{3,10}@\w{3,5}\.\w{2,3}$"; // email pattern
Console.WriteLine($"\nIs email string '{inputEmail}' : {Regex.IsMatch(inputEmail, pattern)}");

//string result = Regex.Replace(input, @"\d{3}-\d{3}-\d{4}", "XXX-XXX-XXXX"); // замінюємо всі телефонні номери на  XXX-XXX-XXXX
string result = Regex.Replace(input, @"\d", ""); // замінюємо всі телефонні номери на  XXX-XXX-XXXX
Console.WriteLine($"\nResult after replacement (delete digits): {result}");

//result.Replace("0", "*");

MatchEvaluator evaluator = match =>
{
    string phone = match.Value;
    return $"({phone.Substring(0, 3)}) {phone.Substring(4, 3)}-{phone.Substring(8, 4)}";
};

result = Regex.Replace(input, @"\d{3}-\d{3}-\d{4}", evaluator); // замінюємо всі телефонні номери на  (123) 456-7890
Console.WriteLine($"After replace :\n{result}");

Regex.IsMatch(result, pattern);
