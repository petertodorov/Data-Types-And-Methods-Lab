﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ExerciseTwo
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine("{0:f12}", area);
    }
}