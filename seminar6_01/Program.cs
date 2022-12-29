Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 <= num2+num3 && num2 <= num1+num3 && num3 <= num1+num2) Console.WriteLine("Это треуольник!!!");
else Console.WriteLine("Это не может быть треугольником!");
