using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExerciseFiveSpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <=n; i++)
        {
            bool special = IsNumberSpecial(i);
            Console.WriteLine("{0} ->{1}", i,special);
        }
    }
    private static bool IsNumberSpecial(int i)
    {
        int sumOfDigits = CalculateSumOfDigits(i);
        bool numberIsSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
        return numberIsSpecial;
    }
    private static int CalculateSumOfDigits(int i)
    {
        int sum = 0;
        while (i>0)
        {
            sum += (i % 10);
            i = (i / 10);
        }
        return sum;
    }
}