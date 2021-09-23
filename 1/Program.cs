using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = Person.GetPersons();
            var r1 = persons.Select(p => p);
            foreach (var item in r1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            var r2 = persons.Where(p => p.IsFemale);
            foreach (var item in r2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            var r3 = persons.OrderBy(p => p.Country);
            foreach (var item in r3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            int[] numbers = { 2, 3, 1, 4, 5 };
            var r7 = numbers.Where((x, index) => x > index);
            foreach (var item in r7)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            var r4 = persons.OrderByDescending(p => p.Country);
            foreach (var item in r4)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            var r5 = persons.OrderBy(p => p.Country).ThenBy(p => p.Age);
            foreach (var item in r5)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            var r6 = persons.GroupBy(p => p.Age / 10);
            foreach (var item in r6)
            {
                foreach (var i in item)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            var r8 = persons.GroupBy(p => p.Country).OrderBy(g => g.Key);
            foreach(var item in r8)
            {
                foreach(var i in item)
                Console.WriteLine(i);
            }
            Console.ReadLine();

            int[] numberss = { 2, 3, 4, 5 };
            //the following returns a query of type IEnumerable<a>
            var r9 = numberss.Select(x => new { Radius = x, Area = Math.PI * x * x });
            foreach(var item in r9)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            string[] first = "a b b c d c".Split();
            string[] second = "a b c e".Split();
            string[] third = "a c d e".Split();
            var query = first.Distinct();

            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            query = second.Except(third);

            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            query = first.Concat(second).Concat(third);

            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            query = first.Intersect(second).Concat(second.Intersect(third));

            foreach (var item in query)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\n");

            Console.ReadLine();




        }
    }
}
