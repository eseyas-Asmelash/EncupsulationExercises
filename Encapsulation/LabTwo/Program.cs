using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employee do you want to add?:  ");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<SalaryIncrease>();
            for (int i = 0; i < lines; i++)
            {
                Console.Write("employee number " + (i + 1) + ":  ");
                var cmdArgs = Console.ReadLine().Split();
                var person = new SalaryIncrease(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
            }
            var bonus = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreasedSalary(bonus));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            Console.ReadKey();

        }
    }
}
