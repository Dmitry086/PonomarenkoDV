// Пономаренко Дмитрий
// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


int a = 0;
int b = 100;

void Rec()
{
	if (a == b)
	{	
		
		Console.Write(b);
		
	}
	else
	{
		Console.Write(a++ + " ");
		Rec();
	}
}

Console.Write("а) ");
Rec();

Console.WriteLine();
Console.Write("б) ");

int a1 = 0;
int b1 = 15;
int c1 = 0;

void RecSum()
{
	if (a1 == b1)
	{	
		
		Console.Write(c1);
		
	}
	else
	{
		a1++;
		c1 = a1 + c1;
		RecSum();
	}
}

RecSum();
