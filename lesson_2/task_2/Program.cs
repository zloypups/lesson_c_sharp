/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
645 -> 5

78 -> третьей цифры нет

32679 -> 6

*/

Console.Clear();
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine());

int x1 = x % 10;
int x2 = x1 % 10;
if (x >= 100 && x <= 999)
{
    Console.WriteLine(x1);
}
else if (x >= 1000)
{
    Console.WriteLine(x2);
}
else
    Console.WriteLine("Это меньше чем трехзначное число");
