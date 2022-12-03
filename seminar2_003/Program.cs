Console.WriteLine("Введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());


if(numA % numB == 0) Console.WriteLine("Первое число кратно второму");

else
{
    int a1 = numA % numB;
    Console.WriteLine($"Остаток от деления: {a1}");
}