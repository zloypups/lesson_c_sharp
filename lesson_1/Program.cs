﻿/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Результат сравнения чисел: {a}, больше {b}, меньше");
}
else if (b > a)
{
    Console.WriteLine($"Результат сравнения чисел: {b}, больше {a}, меньше");
}
else
    Console.WriteLine("числа либо равны, либо код писал какой-то лузер");
