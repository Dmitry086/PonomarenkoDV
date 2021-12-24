// а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
// Требуется подсчитать сумму всех нечётных положительных чисел. 
// Сами числа и сумму вывести на экран, используя tryParse.

Calc1 q1 = new(); //пустая переменная для вызова метода из класса, как-то не красиво и не понятно кажется, подозреваю это не нормально, можно как-то подругому?

File.WriteAllText("all.txt", String.Empty);
File.WriteAllText("sum.txt", String.Empty);

int a = q1.GetNum();
Console.WriteLine($"Cумма всех нечётных положительных чисел = {a}");


string readSUMFile = File.ReadAllText("sum.txt");
Console.WriteLine("Числа для сложения: " + readSUMFile); 

string readAllFile = File.ReadAllText("all.txt");
Console.WriteLine("Все введенные числа: " + readAllFile); 

