//Seminar4Task2 - Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число:");
string number = Console.ReadLine();
int[] massiv = new int[number.Length];
int ConvertNumber = int.Parse(number);

void CreateMassiv(int[] j, int n)
{
    int i = j.Length - 1;
    while (i >= 0)
    {
        int t = n % 10;
        n /= 10;
        j[i] = t;
        i--;
    }
}

int SumMassiv(int[] f)
{
    int sum = f[0];
    for (int q = 1; q < f.Length; sum = sum + f[q], q++) ;
    return sum;
}
CreateMassiv(massiv, ConvertNumber);
Console.WriteLine($"Сумма цифр числа равна: {SumMassiv(massiv)}");