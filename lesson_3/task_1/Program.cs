// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
// б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
// в) Добавить диалог с использованием switch демонстрирующий работу класса.

Complex z1 = new(-2, 23);
Complex z2 = new(-4, 16);

Complex z3 = Complex.Sum(z1 , z2);
Complex z4 = Complex.Sub(z1 , z2);
Complex z5 = Complex.Mult(z1 , z2);

Console.WriteLine($"Имеются два комплексных числа: {z1.Print()} и {z2.Print()}. \n Для сложения чисел нажмите: + \n вычитания: - \n умножения: * ");

string key = Console.ReadLine();

    switch (key)
    {
         case "+":
         Console.WriteLine($"сумма чисел {z1.Print()} и {z2.Print()} = " + z3.Print());
         break;

         case "-":
        Console.WriteLine($"разность чисел {z1.Print()} и {z2.Print()} = " + z4.Print());
         break;

        case "*":
        Console.WriteLine($"произведение чисел {z1.Print()} и {z2.Print()} = " + z5.Print());
         break;

         default:
         Console.WriteLine("Введенные данные не распознаны!");
         break;
     }


