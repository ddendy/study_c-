// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите левую границу промежутка:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите правую границу промежутка:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел в промежутке от {m} до {n} равна: {SumRec(m, n)}");

int SumRec(int m, int n)
{
    if(n==(m-1)) return 0;
    return SumRec(m, n-1) + n;
}