/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int Number = new Random().Next(100, 1000);
Console.WriteLine($"У числа {Number} вторая цифра равна {Number % 100 / 10}");

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

int Num = new Random().Next(10, 10000);
if (Num < 99) Console.WriteLine($"У числа {Num} третьей цифры нет");
else
{
    string A = Num.ToString();
    Console.WriteLine($"У числа {Num} третьея цифра равна {A[2]}");
}

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int Day = new Random().Next(1, 8);
if (Day > 5) Console.WriteLine($"{Day} -> Выходной");
else Console.WriteLine($"{Day} -> Рабочий день");