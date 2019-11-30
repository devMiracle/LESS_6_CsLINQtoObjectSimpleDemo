using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoObjectSimpleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<int> integers = new List<int>() { 1, 100, -4, 56, 876, 0, -10, 900 };
            var filteredIntegers =
                integers
                .Where((integer) => integer > 0)
                //.OrderBy((integer) => integer)
                .OrderByDescending((integer) => integer)
                .Skip(2)
                .Take(2)
                .ToList();
            filteredIntegers.ForEach(Console.WriteLine); */

            List<Person> people =
                new List<Person>() {
                    new Person(){ Name = "John", Age = 15 },
                    new Person(){ Name = "Bill", Age = 55 },
                    new Person(){ Name = "Sarah", Age = 20 }
                };
            List<double> salaries =
                new List<double>() { 10000, 12000, 40000, 56000 };
            var filteredPeople =
                people
                .Select((p) => p.Name)
                .Zip(salaries, (personName, salary) => new { Name = personName, Salary = salary })
                .ToList();
            // filteredPeople.ForEach(Console.WriteLine);
            /*foreach (var item in filteredPeople)
            {
                Console.WriteLine(item.GetType());
            }*/
            var filteredPeopleExpression =
                people
                .Select((p) => p.Name)
                .Zip(salaries, (personName, salary) => new { Name = personName, Salary = salary });
            Console.WriteLine(filteredPeopleExpression);
        }
    }
}
