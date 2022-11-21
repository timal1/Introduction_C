// Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите любое количество чисел через пробел");
string[] numbers = Console.ReadLine().Split(' ');
int numberTask41;
int count = 0;
Console.WriteLine();

void printCount()
{
    for (int i = 0; i < numbers.Length; i++)
    {

        numberTask41 = int.Parse(numbers[i]);
        if (numberTask41 > 0) count++;
    }

    Console.WriteLine(count);

}
printCount();


// Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите коэфициенты через пробел (b1, k1, b2, k2): ");
string[] ratios = Console.ReadLine().Split(' ');
int b1 = int.Parse(ratios[0]);
int k1 = int.Parse(ratios[1]);
double b2 = double.Parse(ratios[2]);
double k2 = double.Parse(ratios[3]);
Console.WriteLine();

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Две прямые совпадают");
}
else if (k1 == k2)
{
    Console.WriteLine("Две прямые параллельны");
}
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пресечения двух прямых: x = {x}, y = {y}");
}




