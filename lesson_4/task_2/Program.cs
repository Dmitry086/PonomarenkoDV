﻿// Пономаренко Дмитрий
//2. Реализуйте задачу 1 в виде статического класса StaticClass;
// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
// б) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
// в)*Добавьте обработку ситуации отсутствия файла на диске.

ForArray.x = new int[20]; 
ForArray.RandArray();
Console.WriteLine(ForArray.PrintArray());
Console.WriteLine(ForArray.Num3());
ForArray.RecArry(@"c:\1\Arrya.txt"); //Записываем полученный массив в файл
ForArray.x = ForArray.ReadArry_txt(@"c:\1\Arrya.txt"); // Считываем файл, получаем массив целых чисел, так же проверяем наличие файла


