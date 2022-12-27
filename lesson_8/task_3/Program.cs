/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.

 Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
*/

void InputMatrix1(int[,] matrix1)
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix1[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void InputMatrix2(int[,] matrix2)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix2[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int[,] matrix1 = new int[3, 3];
int[,] matrix2 = new int[3, 3];
int[,] matrix3 = new int[3, 3];

Console.WriteLine("Первый массив: ");
InputMatrix1(matrix1);
Console.WriteLine();

Console.WriteLine("Второй массив: ");
InputMatrix2(matrix2);
Console.WriteLine();


void ResultMatrix3(int[,] matrix3)
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write($"{matrix3[i, j]} \t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Результат произведения матриц: ");
ResultMatrix3(matrix3);
Console.WriteLine();