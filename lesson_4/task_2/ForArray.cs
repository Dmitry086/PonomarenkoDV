 // Реализуйте задачу 1 в виде статического класса StaticClass;
 static class ForArray
{
   public static int[] x = new int[1];
   
    public static string PrintArray1() //Печать массива
    {
        string output = String.Empty;
        for (int i = 0; i < x.Length; i++)
        {
            output += $"{x[i]} ";
        }
        return output;
    }
    
    public static void RandArray() // Заполнение массива случайными числами
    {
        Random rand = new();
        for (int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(-10000, 10001);
            }
    }

    public static int Num3() // Поиск пар в массиве, исключая ноль
    { 
        int count = 0;
    for (int i = 0; i < x.Length - 1; i++) 
    {
        if (x[i] == 0 & x[i + 1] == 0)
        {
            continue;
        }
        if (x[i] % 3 == 0 & x[i + 1] == 0)
        {
            count++;
        }
        if (x[i] == 0 & x[i + 1] % 3 == 0)
        {
            count++;
        }
        if (x[i] % 3 == 0 & x[i + 1] % 3 == 0)
        {
            continue;
        }
        if (x[i] % 3 != 0 & x[i + 1] % 3 != 0)
        {
            continue;
        }
        if (x[i] % 3 != 0 & x[i + 1] == 0)
        {
            continue;
        }
        if (x[i] == 0 & x[i + 1] % 3 != 0)
        {
            continue;
        }
        else
        {
            count++;
        }
        }

        return count;
    }

    public static void RecArry(string path) // Запись массива в файл
    {
        File.WriteAllText(path, String.Empty);
        for (int i = 0; i < x.Length; i++)
        {
            File.AppendAllText(path, $"{x[i]} ");
        }
        
    }

    public static int[] ReadArry_txt1(string path) // Данные файла в массив с удалением пробелов в начале и конце строки
    {
            int[] result;
            try
            {
            string data = File.ReadAllText(path);
            data = data.Trim();
            result = data.Split(' ').Select(int.Parse).ToArray();
            return result;
            }

            catch
            {
                result = new int[0];
                Console.WriteLine($"Файл {path} не найден или не возможно прочитать!");
            }
            return result;
    }
    
   
   


}