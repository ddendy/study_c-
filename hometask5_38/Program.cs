// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size)
{
    double[] array=new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 101) + new Random().NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (double el in array)
    {
        Console.Write($" {el} ");
    }
    Console.WriteLine();
}

void FindDif(double[] array, int size, double max, double min, double dif)
{
    max = 0;
    min = array[0];
    
    for(int i = 0; i<size; i++)
    {
        if(array[i]>max) max = array[i];
        else if(array[i]<min) min = array[i];
    }
    Console.WriteLine($"Максимальное число массива = {max} ");
    Console.WriteLine($"Минимальное число массива = {min} ");
    dif = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным числами массива = {dif} ");
}

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
double max = 0;
double[] array = CreateArray(size);
double min = array[0];
int dif = 0;
PrintArray(array);
FindDif(array, size, max, min, dif);