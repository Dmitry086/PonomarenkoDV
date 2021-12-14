// Пономаренко Дмитрий
// Написать метод подсчета количества цифр числа.


//Первое, что пришло на ум:
// Console.Write("Введите число:");
// string str = Console.ReadLine();
// Console.WriteLine($"Вы ввели {str}, которое содержит: {str.Length} символов.");


//Наверно, нужно было так:
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = a;
int count = 0;

while (b != 0)
{
    count++;
    b = b / 10;	
}
Console.WriteLine($"Вы ввели {a}, которое содержит: {count} цифр.");