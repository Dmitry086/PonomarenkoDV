class OneDimArry
{
    int[] x;
    public OneDimArry(int len, int start, int step)
    {
        x = new int[len];
        x[0] = start;
        for (int i = 1; i < x.Length; i++)
        {
            x[i] = x[i - 1] + step;
        }
    }
    public OneDimArry(int[] d)
    {
        int count = d.Length;
        x = new int[count];
        for (int i = 0; i < count; i++)
        {
            x[i] = d[i];
        }
    }
    public int Sum()
    {
        int a = 0;
        for (int i = 0; i <= x.Length - 1; i++)
        {
            a = x[i] + a;
        }
        return a;

    }
    public int[] Inverse()
    {
        int[] a = new int[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            a[i] = -x[i];
        }
        return a;

    }
    public void Multi(int multiplier)
    {

        for (int i = 0; i < x.Length; i++)
        {
            x[i] *= multiplier;
        }

    }
    public int Max()
    {

        int max = x[0];
        for (int i = 1; i < x.Length; i++)
        {
            if (x[i] > max) max = x[i];
        }
        return max;
    }
    public int MaxCount()
    {
        int count = 0;
        int max = Max();
        for (int i = 0; i < x.Length; i++)
            if (x[i] == max) count++;
        return count;

    }
    public string PrintArry()
    {
        string output = String.Empty;
        for (int i = 0; i < x.Length; i++)
        {
            output += $"{x[i]} ";
        }
        return output;
    }
    public static void startConsole()
    {
        OneDimArry MyArry = new OneDimArry(10, 2, 12);
        Console.WriteLine("Массив чисел: " + MyArry.PrintArry());
        Console.WriteLine("Сумма всех чисел массива: " + MyArry.Sum());
        Console.WriteLine("Максимальное число в массиве: " + MyArry.Max());
        Console.WriteLine("Максимальных элементов: " + MyArry.MaxCount());
        MyArry.Multi(10); //Умножаем каждый элемент массива
        Console.WriteLine("Массив чисел после умножения: " + MyArry.PrintArry());
        int[] MyArryInv = MyArry.Inverse(); //Создаем массив с измененными знаками
        OneDimArry MyArryInvCopy = new OneDimArry(MyArryInv); //Создаем объект класса OneDimArry (копия массива MyArryInv)
        Console.WriteLine("Массив чисел с измененными знаками: " + MyArryInvCopy.PrintArry());
    }
}

