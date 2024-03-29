﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

double[] FindMidArif(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double result = 0;
    int k = 0;
    for (int j = 0; j < matrix.GetLength(1); j++, k++)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result = matrix[i, j] + result;
        }
        array[k] = result;
        result = 0;
    }
    for (k = 0; k < array.Length; k++)
    {
        array[k] = array[k] / matrix.GetLength(0);
        array[k] = Math.Round(array[k], 1);
    }
    return array;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int[,] array2D = CreateMatrixRndInt(3, 5, 1, 10);
PrintMatrix(array2D);
double[] arr = FindMidArif(array2D);
PrintArray(arr);
