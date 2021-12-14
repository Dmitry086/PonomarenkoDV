// Пономаренко Дмитрий
// *Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. 
// «Хорошим» называется число, которое делится на сумму своих цифр. 
// Реализовать подсчёт времени выполнения программы, используя структуру DateTime.


int a = 0;
int b = 1000000000;
int c = 0;

DateTime start=DateTime.Now;

for(int i = 1; i < b; i++)
{
	int n = i;
	while (n > 0)
	{
		a = n % 10 + a;
		n = n / 10;
	}
	if (i % a == 0)
	{
		c++;
	}

	a = 0;
}

Console.WriteLine(c);
DateTime finish=DateTime.Now;
Console.WriteLine(finish-start);


