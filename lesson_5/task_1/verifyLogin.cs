using System.Text.RegularExpressions;
class verifyLogin
{
    string login;
    public verifyLogin(string tryLogin)
    {
    login = tryLogin;
    }
    public bool strLen() //Проверка кол-ва символов логина
    {     
        int x = login.Length;
        return x >= 2 & x < 10;
    }
    public bool firstСhar() //Проверка первого символа
    {
        return char.IsLetter(login[0]);
    }
    public bool LatinAbs() //Проверка латиницы\цифр
    {
        bool flag = true;
        for (int i = 0; i < login.Length; i++)
        {
            char s = login[i];
            if ((s >= 'a' && s <= 'z')||(s >= 'A' && s <= 'Z') || (char.IsDigit(s)))
            {
                continue;
            }
            else 
            {
                return false;
            }           
        }
        return flag;
    }
        public bool checkReg() //с использованием регулярных выражений
        {
            Regex regex = new Regex(@"^[a-z][a-z\d]{1,8}$", RegexOptions.IgnoreCase);
            return regex.IsMatch(login);
        }

    public string CheckLogin()
    {
        if (strLen() == true && firstСhar() == true && LatinAbs() == true)
        {
             return $"{login} - корректный логин! (без использования регулярных выражений)";
        }
        else
        {
             return $"{login} - логин не прошел проверку!(без использования регулярных выражений)";
        }
    }
    public static void startConsole()
    {
        
        Console.Write("Введите логин: ");
        verifyLogin loginUser = new(Console.ReadLine());
        Console.WriteLine(loginUser.CheckLogin());
        Console.WriteLine(loginUser.checkReg() + " - с использованием регулярных выражений");
    }

}
