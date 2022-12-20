// Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

if (rows == columns)
{
    WriteLine("Количество строк не должно быть равно количеству столбцов");
    return;
}

int[,] array = GetArray(rows, columns, 0, 10);


PrintArray(array);
int[] array2 = GetSum(array);
WriteLine($"номер строки с наименьшей суммой элементов: {MinSum(array2)}");



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


int[] GetSum(int[,] array)
{ 
     int[] newArray = new int[array.GetLength(0)];
     for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum +=  array[i,j];
        }
        newArray[i] = sum;
    }
    return newArray;
}

int MinSum(int[] array)
{
    int minsum = array[0];
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minsum)
        {
            minsum = array[i];
            num = i+1;
        }
    }
    return num;
}