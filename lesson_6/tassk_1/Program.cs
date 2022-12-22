/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);

    if (array[i] > 0)
    {
        result += 1;
    }
}
Console.WriteLine($"наши числа: {string.Join(", ", array)}");
Console.WriteLine(result);