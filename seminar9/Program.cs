﻿/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Write("Введите число N для промежутка от N до 1: ");
int n = int.Parse(Console.ReadLine()!);

void PrintGap(int i)
{
    if (i >= 1)
    {
        Console.Write($"{i} ");
        PrintGap(i - 1);
    }
}

Console.Write($"\n");
PrintGap(n);