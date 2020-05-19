using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabOne;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employee do you want to add?:  ");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                Console.Write("employee number " + (i + 1) + ":  ");
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }

            Team teams = new Team("Lexicon");
            foreach (Person p in persons)
                teams.AddPlayer(p);

            Console.WriteLine(teams.ToString());
            Console.ReadKey();
        }
    }
}
