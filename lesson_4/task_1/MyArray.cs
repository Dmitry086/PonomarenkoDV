class MyArray
{
    int[] x;
    public MyArray(int len)
    {
        x = new int[len];
    }
    public string PrintArray() //Печать массива
    {
        string output = String.Empty;
        for (int i = 0; i < x.Length; i++)
        {
            output += $"{x[i]} ";
        }
        return output;
    }
    public void RandArray() // Заполнение массива случайными числами
    {
        Random rand = new();
        for (int i = 0; i < x.Length; i++)
            {
                x[i] = rand.Next(-10000, 10001); //Для проверки алгоритма поиска удобно использовать рандомайзер (-3, 4)
            }
    }
    public int Num3() //Поиск пар, делитель одного из них 3
    {
        int count = 0;
        for (int i = 0; i < x.Length - 1; i++) 
        if ((x[i] % 3 == 0 & x[i + 1] % 3 != 0) || (x[i] % 3 != 0 & x[i + 1] % 3 == 0))
        {
            count++;
        }
        return count;
    }
}