Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA > numB)
{
    Console.WriteLine($"число {numA} больше ");
}

if(numB > numA)
{
    Console.WriteLine($"число {numB} больше ");
}
