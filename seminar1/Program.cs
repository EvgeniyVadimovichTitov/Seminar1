//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число");
int b = int.Parse(Console.ReadLine());

if (a>b) Console.WriteLine($"max =  {a}; min = {b}");
if (b>a) Console.WriteLine($"max =  {b}; min = {a}");
if (a==b) Console.WriteLine("Числа равны");