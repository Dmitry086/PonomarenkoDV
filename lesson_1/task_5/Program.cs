// Пономаренко Дмитрий
// а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
// б) *Сделать задание, только вывод организовать в центре экрана.
// в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).




Console.WriteLine("Введите ваше имя:");
string name = Console.ReadLine();
Console.WriteLine("Введите вашу фамилию:");
string lastname = Console.ReadLine();
Console.WriteLine("Введите ваш город проживания:");
string city = Console.ReadLine();

Console.Clear();
Console.WriteLine($"a: {name}, {lastname}, {city}.");


int centerX = (Console.WindowWidth / 2);
int centerY = (Console.WindowHeight / 2);
Console.SetCursorPosition(centerX, centerY);
Console.WriteLine($"б: {name}, {lastname}, {city}.");

void Print()
{
    int centerX = (Console.WindowWidth / 2);
    int centerY = (Console.WindowHeight / 2);
    Console.SetCursorPosition(centerX, centerY + 1);
    Console.WriteLine($"в: {name}, {lastname}, {city}.");
}

Print();