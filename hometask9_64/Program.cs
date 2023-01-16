Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"числа в промежутке от {n} до 1: {ListRec(n)}");


string ListRec(int n)
{
    if(n==0) return "";
    return n + ", " + ListRec(n-1);
}