using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExerciseSixTripletsLatinLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int num = 0; num < n; num++)
        {
            for (int num1 = 0; num1 < n; num1++)
            {
                for (int num2 = 0; num2 < n; num2++)
                {
                    Console.Write((char)('a' + num));
                    Console.Write((char)('a' + num1));
                    Console.Write((char)('a' + num2));
                    Console.WriteLine();
                }
                
            }
            
        }
    }
}
