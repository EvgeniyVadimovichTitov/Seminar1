//Seminar4Task3 - Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Введите длину массива:");
int len = int.Parse(Console.ReadLine());
int[] massiv = new int[len];

Console.WriteLine("Введите максимальное значение элемента:");
int max = int.Parse(Console.ReadLine());

void CreateMassiv(int[] j, int l, int m)
{
    for (int i = 0; i < l; j[i] = new Random().Next(m + 1), i++) ;
}

void PrintMassiv(int[] q, int i = 0)
{
    while (i < q.Length)
    {
        Console.Write($"{q[i]} ");
        i++;
    }
}

CreateMassiv(massiv, len, max);
Console.Write("Создан массив: ");
PrintMassiv(massiv);