// Пономаренко Дмитрий
// Написать метод, возвращающий минимальное из трёх чисел.

void minnum()
{
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());
int min;

if (a < b && a < c)
{
    min = a;
}
else
{
    if (b < c)
    {
        min = b;
    }
    else
    {
        min = c;
    }
}

Console.WriteLine($"{min}");
}

minnum();