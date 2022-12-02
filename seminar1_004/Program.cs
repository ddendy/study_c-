Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = n1*-1;

while(n2 <= n1)
{
    Console.Write($" {n2} ");
    n2++;
}
Console.WriteLine();