/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");

        Console.WriteLine();
    }
}

int[,] SumString(int[,] matrix)
{

    int count = 0;
    int min = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }

        Console.WriteLine($"Cумма {i + 1} строки равна: {sum} ");
        if (i == 0) min = sum;
        else if (sum < min)
        {
            min = sum;
            count = i;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"{count + 1} строка с наименьшей суммой ");

    return matrix;
}

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

Console.WriteLine("Исходный массив: ");
InputMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine();
SumString(matrix);