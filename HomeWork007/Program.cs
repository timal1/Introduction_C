// Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int[,] CreateRandomArray(int rows, int colums, int minValue, int maxValye)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValye + 1);

    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

ShowArray(CreateRandomArray(4, 5, 0, 100));
Console.WriteLine();


// Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FindElement(int numberRow, int numberColumn, int[,] arr)
{
    if (numberRow > arr.GetLength(0) || numberColumn > arr.GetLength(1))
    {
        Console.WriteLine("Числа с таким индексом в массиве нет");
        return;
    }
    else Console.WriteLine(arr[numberRow, numberColumn]);

}

FindElement(2, 6, CreateRandomArray(4, 5, 0, 100));
Console.WriteLine();


// Task  52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FindAvgColumn(int[,] arr)
{
    double sumColumn = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
            sumColumn += arr[j, i];
        double avg = sumColumn / arr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} = {avg}");
        sumColumn = 0;
    }
}

int[,] array2 = new int[4, 3] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 1 }, { 7, 8, 2 } };

FindAvgColumn(array2);
Console.WriteLine();
