/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
 Найдите сумму элементов, стоящих на нечётных позициях.

 [3, 7, 23, 12] -> 19

 [-4, -6, 89, 6] -> 0

 */

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);

    if (i % 2 == 1)
    {
        result = result + array[i];
    }
}
Console.WriteLine($"Наш массив: [{string.Join(", ", array)}]");
Console.WriteLine(result);
