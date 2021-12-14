// Пономаренко Дмитрий
// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

int a, b = 0, count = 1;

do
{
    Console.Write($"Введите число № {count}: ");
    a = int.Parse(Console.ReadLine());
    count++;
    if(a % 2 == 0 || a < 0)
    {
        continue;     
    }
    else
    {
        b = b + a;
    }

} while (a != 0);
Console.WriteLine($"Сумма всех нечетных положительниых чисел равна: {b}");