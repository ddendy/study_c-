


// Console.WriteLine("Введите число: ");
//string numA = Console.ReadLine();
//string numB = numA;

//char[] nums = new char[numA.Length];

//for (int i = 0; i < numA.Length; i++)
//{
//  nums[i] = numA[i];
//Console.Write($" {nums[i]} ");



//}

//char[] nums2 = new char[numB.Length];
//for (int j = numB.Length - 1; j >= 0; j -= 1)
//{
//nums2[j] = numB[j];
//Console.Write(nums2[j]);
//}


bool paliCheck(string s)
{
    for (int i = 0; i < s.Length / 2; i++)
    {
        if (s[i] != s[s.Length - i - 1]) return false;


    }
    return true;
}

Console.WriteLine("Введите число:");

string s = Console.ReadLine();
if (paliCheck(s)) Console.WriteLine("Эта строка - палиндром");
else Console.WriteLine("Эта строка - не палиндром");


