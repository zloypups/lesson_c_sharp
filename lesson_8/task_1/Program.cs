/*
Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива. 

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] ModifiedString(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int max = j;
            for (int n = j + 1; n < matrix.GetLength(1); n++)
            {
                if (matrix[i, n] > matrix[i, max]) max = n;

            }
            int t = matrix[i, j];
            matrix[i, j] = matrix[i, max];
            matrix[i, max] = t;

            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    return matrix;
}



Console.Clear();
Console.Write("Задайте размер матрицы через пробел: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine();

Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();

Console.WriteLine("Измененный массив: ");
ModifiedString(matrix);