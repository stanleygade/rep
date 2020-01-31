using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Advanced_opgave_150_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = MCronberg.PersonRepositoryStatic.JustGetPeople(5);
            foreach (var person in people)
                Console.WriteLine(person.Gender + "\t" + person.Name + "\t" + person.Height);
            Console.WriteLine();
            var opg1 = people.Count();
            Console.WriteLine("opg1: " + opg1);

            var opg2 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            foreach (var person in opg2)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            var opg3 = people.Where(i => i.Height < 170);
            foreach (var person in opg3)
                Console.WriteLine(person.Name);
            Console.WriteLine();
            
            var opg4 = people.Where(i => i.Height <= 170 && i.IsHealthy);
            foreach (var person in opg4)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            var opg5 = people.OrderBy(i => i.Name).Select(i => new { Name = i.Name, Height = i.Height });
            foreach (var person in opg5)
            {
                Console.WriteLine(person.Name + " " + person.Height);
            }




        }

    }
}
