// Пономаренко Дмитрий
// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
//    нужно ли человеку похудеть, набрать вес или всё в норме.
// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.


Console.WriteLine("Индекс массы тела.\nВведите ваш вес в килограммах:");
string wt = Console.ReadLine();
double m = Convert.ToDouble(wt);
Console.WriteLine("Ведите ваш рост в метрах:");
string height = Console.ReadLine();
double h = Convert.ToDouble(height);
double i = m/(h*h);
double n = h * 100 - 100;



Console.WriteLine($"Ваш индекс массы тела: {i:F2}");

if (i < 16.0)
{
    Console.WriteLine("Выраженный дефицит массы тела.");
    Console.WriteLine($"Вам нужно набрать {n - m} кг мышечной массы тела.");
}
if (i >= 16.0 & i < 18.5)
{
    Console.WriteLine("Недостаточная (дефицит) масса тела.");
    Console.WriteLine($"Вам нужно набрать {n - m} кг мышечной массы тела.");
}
if (i >= 18.5 & i < 25.0)
{
    Console.WriteLine("Норма.");
    Console.WriteLine($"Вы прекрасны!");
}
if (i >= 25.0 & i < 30.0)
{
    Console.WriteLine("Избыточная масса тела (предожирение).");
    Console.WriteLine($"Вам нужно сбросить {m - n} кг жировой массы тела.");
}
if (i >= 30.0 & i < 35.0)
{
    Console.WriteLine("Ожирение 1 степени!");
    Console.WriteLine($"Вам нужно сбросить {m - n} кг жировой массы тела.");
}
if (i >= 35.0 & i < 45.0)
{
    Console.WriteLine("Ожирение 2 степени!");
    Console.WriteLine($"Вам нужно сбросить {m - n} кг жировой массы тела.");
}
if (i >= 45.0)
{
    Console.WriteLine("Ожирение 3 степени!");
    Console.WriteLine($"Вам нужно сбросить {m - n} кг жировой массы тела.");
}