Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"числа в промежутке от 1 до {n}: {SummaRec(n)}");


string SummaRec(int n)
{
    if(n==0) return "";
    return SummaRec(n-1) + n + ", ";
}