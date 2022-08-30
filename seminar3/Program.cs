// Seminar3Task3 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; Console.WriteLine($" {i} в кубе = {Math.Pow(i, 3)}"), i++) ;