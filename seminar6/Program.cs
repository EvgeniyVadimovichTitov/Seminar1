/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("Введите k1  и b1 для y = k1 * x + b1:");
int k1 = int.Parse(Console.ReadLine()!);
int b1 = int.Parse(Console.ReadLine()!);


Console.Write("Введите k2 и b2 для y = k2 * x + b2:");
int k2 = int.Parse(Console.ReadLine()!);
int b2 = int.Parse(Console.ReadLine()!);

double FoundPerX(int a, int b, int c, int d)
{
    double x = 0;
    return x = (d - b) / (a - c);
}

if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны пересечений нет");
else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые наложены пересечений безконечное множество");
else Console.Write($"координата пересечения: ({FoundPerX(k1, b1, k2, b2)}, {k1 * FoundPerX(k1, b1, k2, b2) + b2})");
