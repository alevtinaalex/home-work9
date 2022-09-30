// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

System.Console.Write("Введите число n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Real(n));

string Real(int num)
{
    if (num == 1)
    return num.ToString();
    return num.ToString() + Real(num-1);
}

