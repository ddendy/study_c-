Console.WriteLine("Введите трёхзначное число: ");
int numA = Convert.ToInt32(Console.ReadLine());

if(numA>100 && numA<999)
{
    int dif1 = numA / 100;
    int dif2 = numA - dif1 * 100;
    int dif3 = dif2 / 10;
    Console.WriteLine($" Второе число цифры: {dif3}");
}    
else
{
    Console.WriteLine(" Число не трёхзначное!!!");
}    


