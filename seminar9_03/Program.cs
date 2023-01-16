// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите левую границу промежутка:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу промежутка:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"числа в промежутке от {m} до {n}: {IntervalRec(m, n)}");

string IntervalRec(int m, int n)
{
    if(n==(m-1)) return "";
    return IntervalRec(m, n-1) + n + ", ";
}