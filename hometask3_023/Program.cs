Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
if(num<0) num=-num;

while(i<=num)
{
    int j = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($" {j} ");
    i++;
}