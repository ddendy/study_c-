// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumDiagonal(int[,] array, int sum)
{
    sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i==j) sum = sum + array[i,j];
            
        }
    }
    return sum;
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
            array[i, j] = new Random().Next(-20,21);
        }
    }
}

Console.WriteLine("Введите количество строк массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
int sum = 0;
FillArray(array);
PrintArray(array);
sum = SumDiagonal(array, sum);
Console.WriteLine(sum);