Console.WriteLine("Введите координату x точки A: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки A: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x точки B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
double By = Convert.ToDouble(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(Ax-Bx, 2)+Math.Pow(Ay-By, 2));
Console.WriteLine($"Расстояние между точками = {length}");