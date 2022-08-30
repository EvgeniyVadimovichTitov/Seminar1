// Seminar3Task1 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число:");
int number = Console.Read();

char[] N = number.ToCharArray();

bool Method(char a, char b)
{
    return a == b;
}

if (Method(N[0], N[4]) && Method(N[1], N[3])) Console.Write("- является палиндромом");
else Console.Write("- не является палиндромом");


