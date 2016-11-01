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
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello, {0} {1}.You are {2} years old.",firstName,lasName, age);
        Console.WriteLine($"Hello, {firstName} {lasName}. You are {age} years old.");
    }
}
