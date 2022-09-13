/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] array = new int[4, 4];
array[0, 0] = 1;

void SpiralFillArray(int[,] massiv, int i = 0, int j = 0, int count = 2, int step = 1)
{
    if (j + step < massiv.GetLength(1) && j + step >= 0)
    {
        if (massiv[i, j + step] == 0)
        {
            massiv[i, j + step] = count;
            count++;
            SpiralFillArray(massiv, i, j + step, count, step);
            return;
        }
    }
    if (i + step < massiv.GetLength(0) && i + step >= 0)
    {
        if (massiv[i + step, j] == 0)
        {
            massiv[i + step, j] = count;
            count++;
            SpiralFillArray(massiv, i + step, j, count, step);
            return;
        }

    }
    if (count != massiv.Length + 1) SpiralFillArray(massiv, i, j, count, step * (-1));
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

SpiralFillArray(array);
PrintArray(array);


