Console.WriteLine("Введите число: ");
string numA = Console.ReadLine();

char[] nums = new char[numA.Length];

if(numA.Length < 3)
{
    Console.WriteLine("Третьего числа нет!!!");
}

for(int i = 0; i < numA.Length; i++)
{
    nums[i] = numA[i];
   
    

}
Console.WriteLine($" Третье число заданной цифры: {nums[2]} ");
