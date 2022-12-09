Console.WriteLine("Введите координату x точки A: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки A: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки A: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x точки B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y точки B: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z точки B: ");
double Bz = Convert.ToDouble(Console.ReadLine());


double length = Math.Sqrt(Math.Pow(Bx-Ax, 2)+Math.Pow(By-Ay, 2)+Math.Pow(Bz-Az, 2));
Console.WriteLine($"Расстояние между точками = {length}");