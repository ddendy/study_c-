Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма чисел от 1 до {n} равна {Summa(n)}");
Console.WriteLine($"сумма чисел от 1 до {n} равна {SummaRec(n)}");

int Summa(int n)
{
    int res = 0;
    while (true)
    {
        res+=n;
        n--;
        if(n==0) break;
    }
    return res;
}

int SummaRec(int n)
{
    if(n==0) return 0;
    return n + SummaRec(n-1);
}