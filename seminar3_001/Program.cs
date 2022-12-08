void CheckKoord(int x, int y)
{
   if(x>0 && y>0) Console.WriteLine("четверть 1");
   else if(x>0 && y<0) Console.WriteLine("четверть 4");
   else if(x<0 && y>0) Console.WriteLine("четверть 2");
   else if(x<0 && y<0) Console.WriteLine("четверть 3");
   else Console.WriteLine("точка на оси координат");
}

string CheckKoord2(int x, int y)
{
   string res;
   if(x>0 && y>0) res = "четверть 1";
   else if(x>0 && y<0) res = "четверть 4";
   else if(x<0 && y>0) res = "четверть 2";
   else if(x<0 && y<0) res = "четверть 3";
   else res = "точка на оси координат";
   return res;
}


try
{
   Console.WriteLine("Введите x: ");
   int x = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите y: ");
   int y = Convert.ToInt32(Console.ReadLine());
   CheckKoord(x,y);
   Console.WriteLine(CheckKoord2(x,y));
}
catch
{
     Console.WriteLine("Надо было вводить целое число ");
}

