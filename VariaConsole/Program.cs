using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariaConsole.Models;

namespace VariaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Person[] people = new Person[4];
            People p = new People();
            PersonDetails.PersonDetail(p.SeedData());
        }
    }
}
