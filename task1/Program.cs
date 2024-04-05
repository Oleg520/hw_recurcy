﻿// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Эта программа выведет все натуральные числа в промежутке от M до N");
System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumbersAB(m,n);

int PrintNumbersAB(int a, int b)
{
    if (a < b)
    {
       System.Console.Write($"{a}, ");
        return PrintNumbersAB(a + 1, b);
    }
    else if (a > b)
    {
        System.Console.Write($"{a}, ");
        return PrintNumbersAB(a - 1, b);
    }
    else
        System.Console.WriteLine(a);
        return a;
}

