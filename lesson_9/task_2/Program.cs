﻿/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
                              n + 1 ,  если m = 0
Функция Аккермана:  A(m, n) = A(m - 1, 1),  если n = 0
 A(m - 1, A(m, n - 1)),   m,n > 0

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int rec(int m, int n)
{
    if (m == 0)
        return (n + 1);
    else if (n == 0)
        return rec(m - 1, 1);
    else
        return rec(m - 1, rec(m, n - 1));


}
Console.Clear();
Console.Write("Введите 1 число :");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число :");
int n = Convert.ToInt32(Console.ReadLine());
while (m < 0)
{
    Console.Write("Вы ошиблись, введите 1 число:");
    m = Convert.ToInt32(Console.ReadLine());
}
while (n < 0)
{
    Console.Write("Вы ошиблись, введите 2 число:");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(rec(m, n));

