﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

System.Console.Write("Введите число m = ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Функция Аккермана ");
System.Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    if (m == 0)
        return (n + 1);
    if (m > 0 && n == 0)
    {
        n = 1;
        return Akkerman(m - 1, n);
    }
    if (m > 0 && n > 0)
        return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}