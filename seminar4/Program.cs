//Seminar4Task1 - Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число:");
int number = 0;
int.TryParse(Console.ReadLine(), out number);

Console.WriteLine("Введите степень:");
int degree = 0;
int.TryParse(Console.ReadLine(), out degree);

int Method(int a, int b)
{
    int n = a;
    int i = 2;
    if (i <= b)
    {
        n *= a;
        i++;
        return n;
    }
    if (b == 0) return 1;
    else return n;
}

Console.WriteLine($"{number} в степени {degree} равно: {Method(number, degree)}");
