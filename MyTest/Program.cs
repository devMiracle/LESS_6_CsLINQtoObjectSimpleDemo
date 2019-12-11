using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> integers = new List<int>() { 1, 100, -4, 55, 800, -10, 222 };

            var filterIntegers = integers
                .Where((integer) => integer > 0)
                .OrderBy((integer) => integer)
                //.OrderByDescending((integer) => integer)
                //.Skip(2)
                //.Take(2)
                .ToList();

            filterIntegers.ForEach(Console.WriteLine);

            List<People> peoples = new List<People>
            {
                new People("Oriana", 18),
                new People("Mira", 22),
                new People("Anlgela", 19),
                new People("Riven", 25),
                new People("Ilao", 20),
            };

            List<double> salaries = new List<double> { 10000, 12000, 40000, 56000 };

            var filterPeople = peoples
                .Select((p) => p.Name)
                .Zip(salaries, (personName, salary) => new { Name = personName, Salary = salaries})
                .ToList();

            filterPeople.ForEach(Console.WriteLine);
            foreach (var item in filterPeople)
            {
                Console.WriteLine(item.GetType());
            }
            var filteredPeopleExpression =
                peoples
                .Select((p) => p.Name)
                .Zip(salaries, (personName, salary) => new { Name = personName, Salary = salary });
            Console.WriteLine(filteredPeopleExpression);
        }
    }
}
