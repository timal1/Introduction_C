// Task 25:  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 

Console.WriteLine("Задача 19: Возводит число A в натуральную степень B");
Console.Write("Введите число, которое нужно возвести в степень: ");
int numberTask25 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите стпень, в которую нужно восвести число: ");
int degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write(numberTask25 + " в степени " + degree + " = " + Math.Pow(numberTask25, degree));



// Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Задача 19: Считает сумму чисел, из которых состоит введенное число");
Console.Write("Введите число: ");
string numberTask27 = Console.ReadLine();
Console.WriteLine();

int sum = 0;

for (int i = 0; i < numberTask27.Length; i++)
{
    sum += int.Parse(numberTask27[i].ToString());
}

Console.Write(sum);


// Task 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

Console.WriteLine("Задача 23: Выводит массив из N элементов");
Console.Write("Введите число: ");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[quantity];

Random ran = new Random();

for (int i = 0; i < quantity; i++)
{
    array[i] = ran.Next(0, 100);
    Console.Write(array[i] + " ");

}
Console.WriteLine();
