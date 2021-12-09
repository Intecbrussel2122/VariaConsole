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
            var p1 = new Person() 
            { 
                Id = 1, 
                Name = "Florian", 
                Address = "Some Address", 
                City = "Brussel", 
                BirthDate = new DateTime(2001, 05, 25), 
                Incomes = 2500.50m 
            };
            var p2 = new Person()
            {
                Id = 2,
                Name = "Sagar",
                Address = "Sagar's Address zeer lange ababaab sjgdfj hjsvf skjhksf kdjhs jhk j",
                City = "Antwerpen",
                BirthDate = new DateTime(1998, 02, 18),
                Incomes = 2300.50m
            };
            var p3 = new Person()
            {
                Id = 3,
                Name = "Olga",
                Address = "Olga's Address",
                City = "Kortrijk",
                BirthDate = new DateTime(2000, 08, 5),
                Incomes = 2600.50m
            };
            var p4 = new Person()
            {
                Id = 3,
                Name = "Wouter",
                Address = "Wouter's Address",
                City = "Gent",
                BirthDate = new DateTime(2000, 08, 5),
                Incomes = 2400.50m
            };

            people[0] = p1;
            people[1] = p2;
            people[2] = p3;
            people[3] = p4;

            Formatters.PersonHeader();
            PersonDetails.PersonDetail(people);

        }
    }
}
