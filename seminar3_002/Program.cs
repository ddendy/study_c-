string dot(int quater)
{
   string koord;
   if(quater == 1) koord = "x>0, y>0";
   else if(quater == 2) koord = "x>0, y<0";
   else if(quater == 3) koord = "x<0, y>0";
   else if(quater == 4) koord = "x<0, y<0";
   else koord = "введите число от 1 до 4";
   return koord;
}

Console.WriteLine("Введите число обозначающее четверть(от 1 до 4): ");
int quater = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(dot(quater));
