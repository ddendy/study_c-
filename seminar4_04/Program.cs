Console.WriteLine("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());


int[] array = new int[n];

for(int i = 0; i<n; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write($" {array[i]} ");
}