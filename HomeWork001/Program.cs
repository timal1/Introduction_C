
// Task 2  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Задача 2: Нахождение максимального из двух чисел");
Console.Write("Введите первое число: ");
int firstNumberTask2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumberTask2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (firstNumberTask2 > secondNumberTask2)
{
    Console.WriteLine("Ответ: " + firstNumberTask2 + " больше " + secondNumberTask2);
}
else if (firstNumberTask2 < secondNumberTask2)
{
    Console.WriteLine("Ответ: " + secondNumberTask2 + " больше " + firstNumberTask2);
}
else
{
    Console.WriteLine("Ответ: числа равны");
}
Console.WriteLine();


// Task 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. 

Console.WriteLine("Задача 4: Нахождение максимального из трех чисел");
Console.Write("Введите первое число: ");
int firstNumberTask3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumberTask3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int thirdNumberTask3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int max = 0;
int count = 3;

int[] array = { firstNumberTask3, secondNumberTask3, thirdNumberTask3 };

for (int i = 0; i < count; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}

if (firstNumberTask3 == secondNumberTask3 & secondNumberTask3 == thirdNumberTask3
 )
{
    Console.WriteLine("Ответ: все введенные числа равны");
}
else
{
    Console.WriteLine("Ответ: " + max + " максимальное из введенных чисел");
}
Console.WriteLine();

// Task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Задача 6: Является ли число четным");
Console.Write("Введите число: ");
int numberTask6 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (numberTask6 % 2 == 0)
{
    Console.WriteLine("Ответ: число " + numberTask6 + " четное ");
}
else
{
    Console.WriteLine("Ответ: число " + numberTask6 + " нечетное ");
}
Console.WriteLine();

// Task 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Задача 8: Вывод всех четных чисел от 1 до введенного");
Console.Write("Введите число: ");
int numberTask8 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Ответ: ");
for (int i = 1; i < numberTask8; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}