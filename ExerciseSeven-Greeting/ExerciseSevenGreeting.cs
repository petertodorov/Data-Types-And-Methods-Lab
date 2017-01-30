using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExerciseSevenGreeting
{
    static void Main(string[] args)
    {
        string firstName = Console.ReadLine();
        string lasName= Console.ReadLine();
        decimal age = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"Hello, {firstName} {lasName}. You are {age} years old.");
    }
}
