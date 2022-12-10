//+ Task 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write("Введите число N: ");
int numberTask64 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void ShowNumbers(int number)
{
    if (number < 1) return;

    Console.WriteLine(number);
    ShowNumbers(number - 1);
}

ShowNumbers(numberTask64);

// Task 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int ShowNumbers2(int m, int n)
{
    if (m < n)
    {
        m += ShowNumbers2(m + 1, n);
    }
    return m;
}

Console.WriteLine($"Сумма элементов от {m} до {n} = {ShowNumbers2(m, n)}");

// Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Write("Введите первое неотрицательное число N: ");
int firstNumberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите второе неотрицательное число M: ");
int secondNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int AccermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return AccermanFunction(n - 1, 1);
    else
        return AccermanFunction(n - 1, AccermanFunction(n, m - 1));
}


Console.WriteLine(AccermanFunction(firstNumberN, secondNumberM));