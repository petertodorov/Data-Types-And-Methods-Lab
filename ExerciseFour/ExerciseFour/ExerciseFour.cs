using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ExerciseFour
    {
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        Ceiling( n, p);
    }
    static void Ceiling(decimal n, decimal p)
    {
        decimal temp = Math.Ceiling(n / p);
        Console.WriteLine(temp);
    }
}

