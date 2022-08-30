// Seminar3Task2 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите Х1: ");
int xa = 0;
int.TryParse(Console.ReadLine(), out xa);

Console.WriteLine("Введите Y1: ");
int ya = 0;
int.TryParse(Console.ReadLine(), out ya);

Console.WriteLine("Введите Z1: ");
int za = 0;
int.TryParse(Console.ReadLine(), out za);

Console.WriteLine("Введите Х2: ");
int xb = 0;
int.TryParse(Console.ReadLine(), out xb);

Console.WriteLine("Введите Y2:");
int yb = 0;
int.TryParse(Console.ReadLine(), out yb);

Console.WriteLine("Введите Z2: ");
int zb = 0;
int.TryParse(Console.ReadLine(), out zb);

Console.WriteLine($"Растояние: {Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2))}");