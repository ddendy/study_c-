int n1 = new Random().Next(99, 1000);
Console.WriteLine($"Рандомное число: {n1}");

int a1 = n1/100;
int a2 = n1 % 10;
Console.WriteLine($"{a1}{a2}");
