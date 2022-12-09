Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i<num)
{
    int j = Convert.ToInt32(Math.Pow(i, 2));
    Console.Write($" {j} ");
    i++;
}