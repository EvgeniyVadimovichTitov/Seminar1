/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите значение m и n  для вычисления суммы элементов промежутка [m;n]: ");
int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);
int sum = 0;

void SumEl(int start, int end, ref int sum)
{
    if (start <= end)
    {
        sum += start;
        SumEl(start + 1, end, ref sum);
    }
}


SumEl(m, n, ref sum);
Console.Write(sum);
