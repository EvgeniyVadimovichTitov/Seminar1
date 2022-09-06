/* Seminar6Task1 - Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.WriteLine("Введите планируемое количесто чисел:");
int count = int.Parse(Console.ReadLine()!);
int[] array = new int[count];

void FillArray(int[] n)
{
    for (int i = 0; i < n.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число:");
        n[i] = int.Parse(Console.ReadLine()!);
    }
}

FillArray(array);

foreach (int el in array)
    Console.Write($"{el}, ");

int FoundArray(int[] m)
{
    int sumMoreZero = 0;
    for (int j = 0; j < m.Length; j++)
        if (m[j] > 0) sumMoreZero++;
    return sumMoreZero;
}
Console.Write($"\n{FoundArray(array)}");