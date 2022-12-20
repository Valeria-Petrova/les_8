// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
///66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

using System;
using static System.Console;
Clear();
Write("Введите x y z через пробел: ");
string[] numbers = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int x = int.Parse(numbers[0]);
int y = int.Parse(numbers[1]);
int z = int.Parse(numbers[2]);
int[,,] array = GetArray(x, y, z, 10, 100);
PrintArray(array);


int[,,] GetArray(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}


void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            WriteLine();
        }
        WriteLine();
    }
}