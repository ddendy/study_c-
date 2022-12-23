int[] CreateArray(int size)
{
    int[] array=new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101);
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

void HowMuch(int[] array, int size, int count)
{
    
    for(int i = 0; i<size; i++)
    {
        if(array[i]>10 && array[i]<99) count+=1;
        
        
    }
    Console.WriteLine($"В массиве {count} чисел от 10 до 99 ");
}

int size = 15;
int count = 0;
int[] array = CreateArray(size);
PrintArray(array);
HowMuch(array, size, count);