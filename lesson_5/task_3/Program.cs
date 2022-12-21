/* 
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
double max = 0;
double min = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * (10 + 10) - 10, 2);
    if (array[i] > max)
    {
        max = array[i];
        min += max;
    }
    else if (array[i] < min)
    {
        min = array[i];
    }
}


Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
Console.WriteLine($" Min: {min}");
Console.WriteLine($" Max: {max}");
Console.WriteLine(max - min);