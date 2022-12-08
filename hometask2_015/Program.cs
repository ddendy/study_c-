Console.WriteLine("Введите число от 1 до 7: ");
int numA = Convert.ToInt32(Console.ReadLine());

if(numA > 1 && numA < 8)
{
    
}
else  Console.WriteLine("Вы ввели неправильное число!");

if(numA == 6) Console.WriteLine("Ура! Это выходной!");
else if(numA == 7) Console.WriteLine("Ура! Это выходной!");
else if(numA > 0 && numA < 6) Console.WriteLine("Это будний день");



