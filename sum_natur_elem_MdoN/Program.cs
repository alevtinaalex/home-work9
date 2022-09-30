// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.Write("Введите число m = ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Сумма натуральных элементов в промежутке от m до n = ");
System.Console.WriteLine(Real(m, n));

int Real(int m, int n)
{
    int a = -1;
    if (m < n)
        a = 1;
    if (n == m)
        return n;
return Real(m, n - a) + n;
}


