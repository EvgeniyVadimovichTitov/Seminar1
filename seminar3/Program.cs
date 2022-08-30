// Seminar3Task1 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число:");
int number = Console.Read();
string newformatnumber = number.ToString();
char[] N = newformatnumber.ToCharArray();

bool Method(char a, char b)
{
    return a == b;
}

if (Method(N[0], N[4]) && Method(N[1], N[3])) Console.Write("- является палиндромом");
else Console.Write("- не является палиндромом");


