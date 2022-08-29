//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int number = new Random().Next(100, 1000);
Console.WriteLine($"Random number = {number}");

string reductnumber = number.ToString();

Console.WriteLine(reductnumber[1]);