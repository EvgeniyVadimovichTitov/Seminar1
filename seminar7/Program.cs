/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("Введите количество строк и солбцов (нижняя строка - ср. арифм. столбцов): ");
int m = int.Parse(Console.ReadLine()!) + 1;
int n = int.Parse(Console.ReadLine()!);

double[,] array = new double[m, n];
double[] arraySrArif = new double[n];
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    if (i < array.GetLength(0) - 1)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
            arraySrArif[j] += array[i, j];
            Console.Write($" {array[i, j]}");
        }
        Console.WriteLine();
    }
    else for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = arraySrArif[j] / (array.GetLength(0) - 1);
            Console.Write($" {array[i, j]} ");
        }

}


