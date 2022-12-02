Console.WriteLine("Введите число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = 1;

while(n2 <= n1)
    {
        if(n2 % 2 ==0)
        {
           Console.Write($" {n2} "); 
        }
        n2++;
    } 
