//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int number = new Random().Next(1, 1000000000);
Console.WriteLine($"Random number = {number}");

string newformatnumber = number.ToString();

if (newformatnumber.Length >= 3) Console.WriteLine(newformatnumber[2]);
else Console.WriteLine("В данном числе два рязряда, операция невозможна");