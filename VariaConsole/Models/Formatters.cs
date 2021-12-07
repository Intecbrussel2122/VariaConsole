using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaConsole.Models
{
    public static class Formatters
    {
       public static void PersonHeader()
        {
            string id = "Id";
            string name = "Name";
            string address = "Address";
            string city = "City";
            string birthDate = "Birth Date";
            string incomes = "Incomes";
            string header = $"{id,-5} {name,-15} {address,-40} {city,-15} {birthDate,-15} {incomes,15}";
            Console.WriteLine(header);
            Console.WriteLine();
        }
    }
}
