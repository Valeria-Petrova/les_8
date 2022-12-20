// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;
using static System.Console;
Clear();
Write("Введите количество строк: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int columns = int.Parse(ReadLine());
int rows2 = rows;
int columns2 = columns;
int[,] Matrix1 = GetArray(rows, columns, 0, 10);
PrintArray(Matrix1);
WriteLine();
int[,] Matrix2 = GetArray(rows2, columns2, 0, 10);
PrintArray(Matrix2);
WriteLine();
GetMultiplyMartix(Matrix1, Matrix2);



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

void GetMultiplyMartix(int[,] array, int[,] inArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int mult = array[i,j] * inArray[i,j];
            Write($"{mult} ");
        }
        WriteLine();
    }
}
