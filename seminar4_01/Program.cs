int sumNumbers(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++) sum+=i;
    return sum;
}

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for(int i = 1; i <= num; i++) sum+=i;
Console.WriteLine($"Сумма от 1 до {num} равна {sumNumbers(num)}");
