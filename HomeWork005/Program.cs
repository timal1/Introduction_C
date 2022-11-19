//Использую одинаковый метод создания массива, так как он подходит для всех задач

int[] CreateRandownArray(int size, int minValue, int maxValue)
{

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
    return array;
}



// Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


void CounterOfEvenNumbers(int[] arr)
{

    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }

    Console.WriteLine("Количество четных чисел в массиве = " + count);

}


CounterOfEvenNumbers(CreateRandownArray(20, 100, 1000));


// Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


void SumOfOddNumbers(int[] arr)
{

    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            sum += arr[i];
        }
    }

    Console.WriteLine("Сумма нечетных чисел в массиве = " + sum);
}

SumOfOddNumbers(CreateRandownArray(10, 1, 10));


// Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


void DifferenceBetweenMinAndMax(int[] arr)
{

    int min = arr[0];
    int max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }

        if (arr[i] < min)
        {
            min = arr[i];
        }
    }

    if (min == max)
    {
        Console.WriteLine("Максимальное и минимальное значения равны = " + min);
    }

    int difference = max - min;

    Console.WriteLine("Разница между максимальным и минимальным значениями равна = " + difference);
}

DifferenceBetweenMinAndMax(CreateRandownArray(10, 1, 100));
