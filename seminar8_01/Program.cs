void ChangeRows(int[,] array, int num)
{
    num = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)   
        {
            num = array[0,j];
            array[0,j] = array[array.GetLength(0)-1,j];
            array[array.GetLength(0)-1,j] = num;
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j< array.GetLength(1); j++)   
        {
            Console.Write($"{array[i,j],3}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-20,21);
        }

    }
}

Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int num = 0;
FillArray(array);
PrintArray(array);
ChangeRows(array, num);
PrintArray(array);
