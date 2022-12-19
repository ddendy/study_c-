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

void CheckEven(int[] array, int size, int count)
{
    
    for(int i=0; i<size;i++)
    {
        if(array[i] % 2 ==0) count +=1;
        else continue;
    }
    Console.WriteLine($" Количество чётных чисел в массиве = {count} ");
}

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = CreateArray(size);
PrintArray(array);
CheckEven(array, size, count);