// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
//  возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента через пробел(номер строки номер столбца): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

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

int FindPosition(int[,] matrix, int[] arr)
{

    if (arr[0] > matrix.GetLength(0) || arr[1] > matrix.GetLength(1) || arr[0] < 0 || arr[1] < 0)
    {
        int result = 0;
        return result;
    }
    else
    {
        int i = arr[0];
        int j = arr[1];
        int result = matrix[i - 1, j - 1];
        return result;
    }

}

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int res = FindPosition(array2D, arr);
if (res == 0) Console.WriteLine("Такого элемента в массиве нет");
else Console.WriteLine($"{res}");
