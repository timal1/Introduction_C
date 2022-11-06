// Task 19:  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 

Console.WriteLine("Задача 19: Является ли число палиндромом");
Console.Write("Введите число: ");
string numberTask19 = Console.ReadLine();
Console.WriteLine();

int[] arrNumber = new int[numberTask19.Length];

for (int i = 0; i < numberTask19.Length; i++)
{

    arrNumber[i] = numberTask19[i];

}

for (int i = 0, j = numberTask19.Length - 1; i < numberTask19.Length / 2; i++, j--)
{
    if (arrNumber[i] != arrNumber[j])
    {
        Console.WriteLine("Введенное число не является палиндромом");
        return;
    }

}
Console.WriteLine("Введенное число является палиндромом");



// Task 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Задача 21: Находит расстояние между двуми точками в 3D пространстве");
Console.Write("Введите координаты первой точки через пробел (x1, y1, z1,): ");
string[] point1 = Console.ReadLine().Split(' ');
int x1 = int.Parse(point1[0]);
int y1 = int.Parse(point1[1]);
int z1 = int.Parse(point1[2]);
Console.WriteLine();
Console.Write("Введите координаты второй точки через пробел (x1, y1, z1,): ");
string[] point2 = Console.ReadLine().Split(' ');
int x2 = int.Parse(point2[0]);
int y2 = int.Parse(point2[1]);
int z2 = int.Parse(point2[2]);
Console.WriteLine();

double distance = Math.Pow((Math.Pow(x2 - x1, 2) +

                         Math.Pow(y2 - y1, 2) +

                         Math.Pow(z2 - z1, 2) *

                                   1.0), 0.5);

Console.Write("Расстояние между введенными точками в трехмерном пространстве = " + distance);




// Task 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Задача 23: Выводит таблицу кубов чисел от 1 до введенного");
Console.Write("Введите число: ");
int numberTask23 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int i = 1; i < numberTask23; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");

}
Console.WriteLine();