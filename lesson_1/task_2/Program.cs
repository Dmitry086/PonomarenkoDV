// Пономаренко Дмитрий
// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.

Console.WriteLine("Индекс массы тела.\nВведите ваш вес в килограммах:");
string wt = Console.ReadLine();
double m = Convert.ToDouble(wt);
Console.WriteLine("Ведите ваш рост в метрах:");
string height = Console.ReadLine();
double h = Convert.ToDouble(height);
double i = m/(h*h);

Console.WriteLine($"Ваш индекс массы тела: {i:F2}");