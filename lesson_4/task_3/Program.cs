/*
 Напишите программу, которая спрашивает у пользователя кол-во элементов и
 спрашивает сами элементы. После записи элементов в массив, 
 необходимо его вывести на экран.
 8
 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/


Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine());

int[] N = new int[a];

for (int i = 0; i < N.Length; i++)
{
    Console.Write($"Введите элемент: ");
    N[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(", ", N)}]");