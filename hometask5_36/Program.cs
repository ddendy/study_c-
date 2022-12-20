int[] CreateArray(int size)
{
    int[] array=new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
    {
        Console.Write($" {el} ");
    }
    Console.WriteLine();
}

void Sum(int[] array, int size, int sum1)
{
    
    for(int i = 1; i<size; i+=2)
    {
        sum1 = sum1 + array[i];
        
    }
    Console.WriteLine($" Сумма чисел на нечётных позициях =  {sum1} ");
}

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int sum1 = 0;
int[] array = CreateArray(size);
PrintArray(array);
Sum(array, size, sum1);