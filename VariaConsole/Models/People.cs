using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaConsole.Models
{
    public class People
    {
        Person[] people = new Person[4];

        public Person[] GetPeople
        {
            get { return people; }
        }

        public Person[] SeedData()
        {
           
           people[0] = new Person()
            {
                Id = 1,
                Name = "Florian",
                Address = "Some Address",
                City = "Brussel",
                BirthDate = new DateTime(2001, 05, 25),
                Incomes = 2500.50m
            };
            people[1] = new Person()
            {
                Id = 2,
                Name = "Sagar",
                Address = "Sagar's Address zeer lange ababaab sjgdfj hjsvf ",
                City = "Antwerpen",
                BirthDate = new DateTime(1998, 02, 18),
                Incomes = 2300.50m
            };
            people[2] = new Person()
            {
                Id = 3,
                Name = "Olga",
                Address = "Olga's Address",
                City = "Kortrijk",
                BirthDate = new DateTime(2000, 08, 5),
                Incomes = 2600.50m
            };
            people[3] = new Person()
            {
                Id = 3,
                Name = "Wouter",
                Address = "Wouter's Address",
                City = "Gent",
                BirthDate = new DateTime(2000, 08, 5),
                Incomes = 2400.50m
            };

            return people;
        }
    }
}
