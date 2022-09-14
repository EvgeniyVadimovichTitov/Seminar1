/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

uint M = 3;
uint N = 4;

static uint FunctionAkkermana(uint m, uint n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return FunctionAkkermana(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAkkermana(m - 1, FunctionAkkermana(m, n - 1));
    return FunctionAkkermana(m, n);
}
Console.Write(FunctionAkkermana(M, N));