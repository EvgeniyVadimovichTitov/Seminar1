//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int number = new Random().Next(1, 8);
Console.WriteLine($"Random week's day = {number}");

int[] DayWeek = { 1, 2, 3, 4, 5, 6, 7 };

if (number == DayWeek[5] || number == DayWeek[6]) Console.WriteLine("Yes");
else Console.WriteLine("No");

