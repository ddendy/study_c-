Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if(num1 > 0 && num1 <= 999)
{
    int num2 = num1/100;
    int num3 = num1-num2*100;
    int num4 = num3/10;
    int num5 = num3-num4*10;

    Console.WriteLine($"Третяя цифра этого числа: {num5}");
}

if(num1 > 999 && num1 <= 9999 ) //8765
{
    int num2 = num1/1000; //8
    int num3 = num1-num2*1000; //765
    int num4 = num3/100; //7
    int num5 = num3-num4*100; //65
    int num6 = num5/10; //6
   
   Console.WriteLine($"Третяя цифра этого числа: {num4}");
}


