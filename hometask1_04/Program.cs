Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numC = Convert.ToInt32(Console.ReadLine());

if(numA > numB && numA > numC)
{
    Console.WriteLine($"число {numA} больше ");
}

if(numB > numA && numB > numC)
{
    Console.WriteLine($"число {numB} больше ");
}

if(numC > numA && numC > numB)
{
    Console.WriteLine($"число {numC} больше ");
}
