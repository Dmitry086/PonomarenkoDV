class OneDimArry
{
    int[] x;

    public OneDimArry(int len, int start, int step)
    {
        x = new int[len];
        x[0] = start;
        for(int i = 1; i < x.Length; i++)
            {
                x[i] = x[i - 1] + step;
            }
    }

    public int Sum()
    {   
        int a = 0;
        for(int i = 0; i <= x.Length - 1; i++)
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
            x[i] = x[i] * multiplier;
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












}