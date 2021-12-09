using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaConsole.Models
{
    public static class PersonDetails
    {
        public static void PersonDetail(Person[] people)
        {
            decimal total = 0;
            foreach (var person in people)
            {
                string detail = string.Empty;
                if (person.Address.Length > 40)
                {
                     detail = $"{person.Id,-5} {person.Name,-15} {person.Address.Substring(0, 39),-40} {person.City,-15} {person.BirthDate.ToShortDateString(),-15} {person.Incomes,15:C}";
                }
                else
                {
                     detail = $"{person.Id,-5} {person.Name,-15} {person.Address,-40} {person.City,-15} {person.BirthDate.ToShortDateString(),-15} {person.Incomes,15:C}";
                }
                Console.WriteLine(detail);
                total += person.Incomes;
            }

            Console.WriteLine();
            string totalText = "Total";
            Console.Write(totalText.PadRight(101,'.'));
            Console.WriteLine($"{total:c}");
        }
    }
}
