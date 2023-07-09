// Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.


using System;
class Program
{
static void Main()
{
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = SumFromMToN(m, n);
Console.WriteLine("Сумма натуральных элементов от M до N: " + sum);
}
static int SumFromMToN(int m, int n)
{
if (m > n)
{
throw new ArgumentException("Значение M должно быть меньше или равно N");
}

if (m == n)
{
return m;
}
else
{
return m + SumFromMToN(m + 1, n);
}
}
}
