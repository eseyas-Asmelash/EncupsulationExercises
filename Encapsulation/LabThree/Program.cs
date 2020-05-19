using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThree
{
    class Program
    {
        static void Main()
        {
            Console.Write("How many employee do you want to add?:  ");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<ValidateInput>();
            for (int i = 0; i < lines; i++)
            {
                Console.Write("employee number " +(i+1) + ":  ");
                var cmdArgs = Console.ReadLine().Split();
                var person = new ValidateInput(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                persons.Add(person);
                
            }

            persons.ForEach(p => Console.WriteLine(p.ToString()));
            Console.ReadKey();
        }
    }
}
