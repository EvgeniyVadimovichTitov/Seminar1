/* Seminar5Task1 - Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Write("Введите длину массива: ");
int len = int.Parse(Console.ReadLine()!);
int[] massiv = new int[len];

void CreateMassiv(int[] array)
{
    for (int i = 0; i < array.Length; array[i] = new Random().Next(100, 1000), i++) ;
}

void PrintMassiv(int[] array)
{
    for (int i = 0; i < array.Length; Console.Write($"{array[i]} "), i++) ;
}

CreateMassiv(massiv);
PrintMassiv(massiv);

int chetEl = 0;
for (int j = 0; j < massiv.Length; j++)
{
    if (massiv[j] % 2 == 0) chetEl++;
}
Console.Write($"\n Колличество четных элементов в массиве: {chetEl}");