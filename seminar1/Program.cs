//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine());

int max = a;
if (b>max) max = b;
if (c>max) max = c;
if (max==b && max==c) Console.WriteLine("Числа равны");

Console.WriteLine($"max= {max}");

