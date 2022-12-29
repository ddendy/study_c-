Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
string res = "";

while (num1 > 0)
{
    res = Convert.ToString(num1%2) + res;
    num1 = num1 / 2;
    
}    
Console.WriteLine(res);