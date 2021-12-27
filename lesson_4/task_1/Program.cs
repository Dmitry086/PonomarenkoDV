// Пономаренко Дмитрий
// 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
// Заполнить случайными числами. Написать программу, позволяющую найти и вывести количество пар элементов массива, 
// в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива.
// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.

int[] MyArray = new int[20];
int count = 0;

void RandArray(int[] arr)
{
    Random rand = new();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-10000, 10001);
    }
}

RandArray(MyArray);
Console.Write("Массив: ");
for (int i = 0; i < MyArray.Length; i++)
{
    Console.Write($"{MyArray[i]} ");
}

for (int i = 0; i < 19; i++) // 0/n = 0, поэтому столько исключений для нуля
{
    if (MyArray[i] == 0 & MyArray[i + 1] == 0)
    {
        continue;
    }
    if (MyArray[i] % 3 == 0 & MyArray[i + 1] == 0)
    {
        count++;
    }
    if (MyArray[i] == 0 & MyArray[i + 1] % 3 == 0)
    {
        count++;
    }
    if (MyArray[i] % 3 == 0 & MyArray[i + 1] % 3 == 0)
    {
        continue;
    }
    if (MyArray[i] % 3 != 0 & MyArray[i + 1] % 3 != 0)
    {
        continue;
    }
    if (MyArray[i] % 3 != 0 & MyArray[i + 1] == 0)
    {
        continue;
    }
    if (MyArray[i] == 0 & MyArray[i + 1] % 3 != 0)
    {
        continue;
    }
    else
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine($"Количество пар: {count}");