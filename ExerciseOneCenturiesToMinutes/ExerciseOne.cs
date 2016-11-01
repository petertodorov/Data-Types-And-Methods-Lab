using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CenturiesToMinutes
{
    static void Main()
    {
        double century= double.Parse(Console.ReadLine());
        double year = century * 100;
        double days = Math.Floor(year * 365.2422);
        double hours = Math.Floor(days * 24);
        double minutes = Math.Floor(hours * 60);
        Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes",
            century,year,days,hours, minutes);
    }
}
