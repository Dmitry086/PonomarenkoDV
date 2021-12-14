// Пономаренко Дмитрий
// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
// программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

string login = "root";
string pwd = "GeekBrains";
int count = 2;

Console.Write("Логин: ");
string ulogin = Console.ReadLine();

do
{
    Console.Write("Пароль: ");
    string upwd = Console.ReadLine();

    if (login == ulogin && pwd == upwd)
    {
        Console.WriteLine("Логин и пароль верны!");
        Console.Write($"user@{ulogin}:");
        Console.ReadLine();
        break;   
    }
    else
    {
        Console.WriteLine($"Не верный логин или пароль, остальсь {count} попыток!");  
        count --;
    }
} while (count != -1);