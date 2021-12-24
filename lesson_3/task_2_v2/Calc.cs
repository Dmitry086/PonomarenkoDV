
class Calc1
{
    public int GetNum()
    {
        int sum = 0;
        int count = 0;
        
        //List<int> AllNum = new List<int>();
        //List<int> forSum = new List<int>();
        //int[] AllNum = new int[10];
        //int[] forSum = new int[10];

        int result;
        bool flag;

        do
        {
        count++;
        do
        {
            Console.WriteLine($"Введите число № {count}");
            flag = int.TryParse(Console.ReadLine(), out result);
        } while (!flag);

        if(flag == true) File.AppendAllText("all.txt", $"{result} ");

        if(result % 2 != 0 & result > 0) 
        {
            sum = sum + result;
            File.AppendAllText("sum.txt", $"{result} ");
        }
        }
        while (result != 0);
        

        return sum;




    }

}

