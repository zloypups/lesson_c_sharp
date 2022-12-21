/*
 Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
 числами. Напишите программу, которая покажет количество чётных чисел в массиве.

 [345, 897, 568, 234] -> 2
 */

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);

    if (array[i] % 2 == 0)
    {
        result += 1;
    }
}
Console.WriteLine($"Наш массив: [{string.Join(", ", array)}]");
Console.WriteLine(result);