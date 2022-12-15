int amount(int num)
{
    int count = 0;
    while (num >= 1)
    {
        num = num / 10;
        count++;
    }
    return count;

}

Console.WriteLine("Введите число:");
double num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе: {amount(num)}");
