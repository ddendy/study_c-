Console.WriteLine("Введите числа массива: ");
string numA = Console.ReadLine();

char[] nums = new char[numA.Length];
for(int i = 0; i < numA.Length; i++)
{
    nums[i] = numA[i];
    Console.Write($" {nums[i]} ");
}

