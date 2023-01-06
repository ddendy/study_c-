void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] array, int rows, int cols)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i+j;
        }
    }
}


Console.WriteLine("Введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array, rows, cols);
PrintArray(array);