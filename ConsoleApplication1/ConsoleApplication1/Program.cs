using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ExerciseNineAnimalType
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        AnimalType(name);
    }
    static void AnimalType(string name)
    {
        switch (name)
        {
            case "dog": Console.WriteLine("mammal"); break;
            case "tortoise": Console.WriteLine("reptile"); break;
            case "crocodile": Console.WriteLine("reptile"); break;
            case "snake": Console.WriteLine("reptile"); break;
            default: Console.WriteLine("Unknown"); break;
        }
    }
}

