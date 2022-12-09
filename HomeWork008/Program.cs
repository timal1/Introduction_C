//+ Task 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
    if (array == null)
    {
        Console.Write("Массива нет");
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }

}

void SortRowDescInArray(int[,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int k = 0; k < inArray.GetLength(1); k++)
            for (int j = 0; j < inArray.GetLength(1) - k - 1; j++)
            {
                if (inArray[i, j] < inArray[i, j + 1])
                {
                    int temp = inArray[i, j];
                    inArray[i, j] = inArray[i, j + 1];
                    inArray[i, j + 1] = temp;
                }
            }
    }
}

int[,] array = CreateRandomArray(4, 5, 0, 100);
SortRowDescInArray(array);
ShowArray(array);
Console.WriteLine();


//+ Task 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void FindRowMinSumElement(int[,] arr)
{
    int sumRow = 0;
    int sumRowCurrent = 0;
    int rowMinSumElement = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            sumRowCurrent += arr[i, j];

        if (i == 0 || sumRowCurrent < sumRow)
        {
            sumRow = sumRowCurrent;
            rowMinSumElement = i;
        }
        sumRowCurrent = 0;
    }
    Console.WriteLine($"В строке {rowMinSumElement} наименьшая сумма элементов равная {sumRow}");
}

FindRowMinSumElement(CreateRandomArray(4, 5, 0, 100));
Console.WriteLine();


//+ Task 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] MultiplyTwoMatrices(int[,] arr1, int[,] arr2)

{
    if (arr1.GetLength(0) != arr2.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя переумножить");
        return null;
    }

    int result = 0;
    int[,] multiplyTwoMatrices = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int l = 0; l < arr2.GetLength(1); l++)
    {
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(0); j++)

            {
                result += arr1[l, j] * arr2[j, i];
            }
            multiplyTwoMatrices[l, i] = result;
            result = 0;
        }
    }
    return multiplyTwoMatrices;
}

ShowArray(MultiplyTwoMatrices(CreateRandomArray(4, 5, 0, 10), CreateRandomArray(5, 4, 0, 10)));
Console.WriteLine();


//+Task 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandomArray3(int rows, int colums, int layers, int minValue, int maxValye)
{
    int[,,] array = new int[rows, colums, layers];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            for (int k = 0; k < layers; k++)
            {
                int value;
                do
                {
                    value = new Random().Next(minValue, maxValye + 1);
                } while (!FindElementInArray3(array, value));

                array[i, j, k] = value;

            }
    return array;
}


bool FindElementInArray3(int[,,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value) return false;
            }
        }
    }
    return true;
}

void ShowArray3(int[,,] array)
{

    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k]}({i} {j} {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }


}
ShowArray3(CreateRandomArray3(4, 3, 2, 0, 100));

