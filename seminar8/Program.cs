/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] array = new int[8, 8];

void FillAndPrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(10);
            Console.Write($"{massiv[i, j]} ");
        }
        Console.Write("\n");
    }
}

void SortArray(int[,] massiv, int temp = 0)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1) - 1; j++)
        {
            for (int g = 0; g < massiv.GetLength(1) - 1; g++)
                if (massiv[i, g] < massiv[i, g + 1])
                {
                    temp = massiv[i, g];
                    massiv[i, g] = massiv[i, g + 1];
                    massiv[i, g + 1] = temp;
                }
        }
    }
}

void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
            Console.Write($"{massiv[i, j]} ");
        Console.Write("\n");
    }
}

FillAndPrintArray(array);
Console.Write("\n");
Console.Write("\n");
SortArray(array);
PrintArray(array);

