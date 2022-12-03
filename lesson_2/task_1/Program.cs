/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

int x1 = x / 10;
int x2 = x1 % 10;

Console.WriteLine(x2);
// Console.WriteLine(x1 % 10);