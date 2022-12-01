Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numB == Math.Sqrt(numA))
{
    Console.WriteLine("Да");
}

if(numB != Math.Sqrt(numA))
{
Console.WriteLine("Нет");
}