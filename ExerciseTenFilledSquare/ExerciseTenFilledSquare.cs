using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExerciseTenFilledSquare
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        PrintHeaderRows(n);
        PrintMiddleRow(n);
        PrintHeaderRows(n);

    }
    static void PrintHeaderRows(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }
    static void PrintMiddleRow(int n)
    {
        for (int i = 0; i < n-2; i++)
        {
            Console.Write('-');

            for (int j = 0; j < n - 1; j++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}
