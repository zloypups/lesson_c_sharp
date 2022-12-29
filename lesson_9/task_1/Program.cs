/*
 Задача 66: Задайте значения M и N. 
 Напишите программу, которая найдёт сумму натуральных элементов 
 в промежутке от M до N.

 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
*/

int rec(int m, int n)
{
    if (n == m)
        return m;
    return rec(m, n - 1) + n;
}


Console.Clear();
Console.Write("Введите 1 число : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));