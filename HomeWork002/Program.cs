// Task 10:  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

Console.WriteLine("Задача 10: Показывает разряд - десятки введеного числа");
Console.Write("Введите трехзначное число: ");
int numberTask10 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void ShowTens(int number)
{
    Console.WriteLine(number / 10 % 10);
}

ShowTens(numberTask10);

// Variant 2:

// int ShowTens2(int number)
// {
//     int result = number / 10;
//     return result;
// }

// Console.WriteLine(ShowTens2(numberTask10));


// Task 13:  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Задача 13: Показывает разряд - сотни введеного числа");
Console.Write("Введите число с разрядностью не меньше сотен: ");
string numberTask13 = Console.ReadLine();
Console.WriteLine();

void ShowHundreds(string number)
{
    int resultInt;

    if (number.Length >= 3)
    {
        char result = number[number.Length - 3];

        resultInt = (int)char.GetNumericValue(result);

    }
    else
    {
        Console.WriteLine("Во веденном числе сотен нет");
        return;
    }

    if (resultInt >= 0)
    {
        Console.WriteLine(resultInt);
    }
    else
    {
        Console.WriteLine("Во веденном числе вместо сотен ввели символ");
    }
}

ShowHundreds(numberTask13);


// Task 15:  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Задача 15: Показывает является ли введенный день недели выходным днем");
Console.Write("Введите цифрой день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

bool GetHolidays(int number)
{
    return number == 6 || number == 7;
}

Console.WriteLine(GetHolidays(dayWeek));