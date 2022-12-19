// int[] NewArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(-100, 100);
//     }
//     return array;
// }

// int[] ChangeArray(int[] array)
// {
//     for (int g = 0; g < size; g++)
//     {
//         array[g] = array[g] * -1;
//         Console.Write($"Изменённый массив: {array[g]} ");
//     }
//     return array;
// }


Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());


int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 100);
    Console.Write($" {array[i]} ");
}


for (int g = 0; g < size; g++)
{
    array[g] = array[g] * -1;
    Console.WriteLine($" {array[g]} ");
}
