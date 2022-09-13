/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
int x1 = 2;
int y1 = 2;
int x2 = 2;
int y2 = 2;
int[,] arrayOne = new int[x1, y1];
int[,] arraySecond = new int[x2, y2];
int[,] arrayOnexarraySecond = new int[x1, y2];

void FillAndPrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = new Random().Next(0, 10);
            Console.Write($"{massiv[i, j]} ");
        }
        Console.WriteLine();
    }
}
void MultiplicationMatrix(int[,] massiv, int[,] massiv1, int[,] massiv2)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            for (int t = 0; t < y2; t++)
                massiv[i, j] += massiv1[i, t] * massiv2[t, j];
        }

    }
}
void PrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
            Console.Write($"{massiv[i, j]} ");
        Console.WriteLine();
    }
}

if (x1 != y2) Console.Write("Матрицы не согласованы произведение невозможно!");
FillAndPrintArray(arrayOne);
Console.WriteLine();
FillAndPrintArray(arraySecond);
Console.WriteLine();
MultiplicationMatrix(arrayOnexarraySecond, arrayOne, arraySecond);
PrintArray(arrayOnexarraySecond);
