/* Seminar5Task2 - Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

float[] array = new float[new Random().Next(1, 11)];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write($"{array[i]} ");
}
float FoundMax(float[] massiv)
{
    float max = massiv[0];
    for (int j = 1; j < massiv.Length; j++)
    {
        if (massiv[j] > max) max = massiv[j];
    }
    return max;
}
float FoundMin(float[] massiv)
{
    float min = massiv[0];
    for (int j = 1; j < massiv.Length; j++)
    {
        if (massiv[j] < min) min = massiv[j];
    }
    return min;
}

Console.Write($"\n Разница между максимальным и минимальным элементами массива равна: {FoundMax(array) - FoundMin(array)}");