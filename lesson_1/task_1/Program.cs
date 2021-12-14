// Пономаренко Дмитрий
// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
// а) используя склеивание;
// б) используя форматированный вывод;
// в) используя вывод со знаком $.

Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine("Введите вашу фамилию:");
string lastname = Console.ReadLine();
Console.WriteLine("Введите ваш возраст:");
string age = Console.ReadLine();
Console.WriteLine("Введите ваш рост:");
string height = Console.ReadLine();
Console.WriteLine("Введите ваш вес:");
string wt = Console.ReadLine();

Console.WriteLine("Используя склеивание:");
Console.WriteLine("Имя: " + name + ", " + "Фамилия: " + lastname + ", " + "возраст: " + age + ", " + "рост: " + height + ", " + "вес: " + wt);

Console.WriteLine("Используя форматированный вывод:");
string format = String.Format("{0}, {1}, {2}, {3}, {4}" , name, lastname, age, height, wt);
Console.WriteLine(format);

Console.WriteLine("используя вывод со знаком $:");
Console.WriteLine($"{name}, {lastname}, {age}, {height}, {wt}");