/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка*/

int[,] array = new int[10, 2 + 1];//+1 для суммы строк, юзер не увидет его


void FillAndPrintArray(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        massiv[i, massiv.GetLength(1) - 1] = 0;
        for (int j = 0; j < massiv.GetLength(1) - 1; j++)
        {
            massiv[i, j] = new Random().Next(10);
            massiv[i, massiv.GetLength(1) - 1] += massiv[i, j];
            Console.Write($"{massiv[i, j]} ");
        }
        Console.Write("\n");
    }
}

void FoundMaxString(int[,] massiv)
{
    int minEl = massiv[0, massiv.GetLength(1) - 1];
    for (int i = 1; i < array.GetLength(0); i++)
    {
        if (minEl > massiv[i, massiv.GetLength(1) - 1]) minEl = massiv[i, massiv.GetLength(1) - 1];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (minEl == massiv[i, massiv.GetLength(1) - 1])
            Console.WriteLine($"{i + 1} строка с наименьшей суммой элементов");/* позволит вывести все строки 
                                                                             при наличии нескольких минимумом*/
    }
}

FillAndPrintArray(array);
Console.Write("\n");
FoundMaxString(array);


