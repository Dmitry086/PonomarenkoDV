// а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
// Требуется подсчитать сумму всех нечётных положительных чисел. 
// Сами числа и сумму вывести на экран, используя tryParse.

int a, b = 0, count = 1;

File.WriteAllText("all.txt", String.Empty);
File.WriteAllText("sum.txt", String.Empty);

void Sum()
{
    do
{
    Console.Write($"Введите число № {count}: ");
    string input = Console.ReadLine();

    bool result = int.TryParse(input, out a);
    if(result == true)
    {
    File.AppendAllText("all.txt", $"{a} ");
    count++;
    if(a % 2 == 0 || a < 0)
    {
        continue;     
    }
    else
    {
        File.AppendAllText("sum.txt", $"{a} ");
        b = b + a;
    }
    }
    else
    {
        Console.WriteLine("Число не распознано, повторите попытку!");
        Sum();
    }
} while (a != 0);
}
Sum();
Console.WriteLine($"Сумма всех нечетных положительных чисел равна: {b}");

string readSUMFile = File.ReadAllText("sum.txt");
Console.WriteLine("Числа для сложения: " + readSUMFile); 

string readAllFile = File.ReadAllText("all.txt");
Console.WriteLine("Все введенные числа: " + readAllFile); 