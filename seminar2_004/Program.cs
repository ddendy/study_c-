Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
if(numA % 7 == 0 && numA % 23 == 0) Console.WriteLine("Да");
else
{
    Console.WriteLine("Нет");
}