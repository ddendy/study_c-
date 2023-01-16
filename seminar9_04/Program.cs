int SumNum(int m)
{
    if(m==0) return 0;
    return SumNum(m/10) +m%10;
}

Console.WriteLine("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(m);
Console.WriteLine($"Сумма цифр числа = {sum}");