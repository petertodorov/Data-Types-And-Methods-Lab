using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExerciseThree
{
    static void Main(string[] args)
    {
        decimal numberToEnter = decimal.Parse(Console.ReadLine());
        decimal sum = 0;
        for (int i = 0; i < numberToEnter; i++)
        {
            decimal temp = decimal.Parse(Console.ReadLine());
            sum += temp;
        }
        Console.WriteLine(sum);
    }
}
