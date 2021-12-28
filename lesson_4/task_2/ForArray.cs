 static class ForArray
{
   public static int[] x;
   
    public static string PrintArray() //Печать массива
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
    public static int Num3() //Поиск пар, делитель одного из них 3
    {
        int count = 0;
        for (int i = 0; i < x.Length - 1; i++) 
        if ((x[i] % 3 == 0 & x[i + 1] % 3 != 0) || (x[i] % 3 != 0 & x[i + 1] % 3 == 0))
        {
            count++;
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
    public static int[] ReadArry_txt(string path) // Данные файла в массив с удалением пробелов в начале и конце строки, проверка файла
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