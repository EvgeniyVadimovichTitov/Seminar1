/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет*/

Console.Write("Введите количество строк и солбцов: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

int[,] array = new int[m, n];
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($" {array[i, j]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите идентефикаторы искомого элемента (строка и столбец): ");
int numbString = int.Parse(Console.ReadLine()!);
int numbStolb = int.Parse(Console.ReadLine()!);
Console.WriteLine();

if (numbString > array.GetLength(0) || numbStolb > array.GetLength(1))
    Console.Write("Такого элемента нет");
else for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == numbString && j == numbStolb)
                Console.Write(array[i, j]);
        }
    }


