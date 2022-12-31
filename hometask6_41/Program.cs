//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



// int[] FillArray( int N)
// {

//     int[] array = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         Console.WriteLine("Введите число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($" {el} ");
//     }
//     Console.WriteLine();
// }

// void SearchAboveZero(int count, int[] array)
// {
//     count = 0;
//     foreach (int lol in array)
//     {
//         if(lol>0) count+=1;
//     }
//     Console.WriteLine($"Количество чисел больше 0 = {count} ");
// }


void CheckAboveZero(int num, int count, int N)
{
    for (int i = 0; i < N; i++)
    {
        Console.WriteLine("Введите число: ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) count += 1;
    }
    Console.WriteLine($"Количество чисел больше 0 = {count}");
}

Console.WriteLine("Сколько чисел вы хотите ввести?");
int N = Convert.ToInt32(Console.ReadLine());
int num = 0;
int count = 0;
CheckAboveZero(num, count, N);