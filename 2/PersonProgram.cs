using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuerySyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = Person.GetPersons();
            #region Query 1

            //var r1 = from p in persons select p;
            //foreach (var p in r1)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Query 2

            //var r2 = from p in persons
            //         where p.IsFemale
            //     select p;
            //foreach (var p in r2)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Query 3

            //var r3 = from p in persons
            //         where p.Country == "US"
            //         select p;
            //foreach (var p in r3)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion


            #region Query 4

            //var r4 = from p in persons
            //         where p.Name.Split()[1].ToCharArray()[0] == 'W'
            //         select p;
            //foreach (var p in r4)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Query 5
            //var r5 = from p in persons
            //         orderby p.Age
            //         select p;
            //foreach (var p in r5)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Query 6
            //var r6 = from p in persons
            //         orderby p.Name.Split()[1]
            //         select p;
            //foreach (var p in r6)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion

            #region Query 7
            //var r7 = from p in persons
            //         group p
            //         by p.IsFemale;
            //foreach (var aGroup in r7)
            //{
            //    Console.WriteLine("{0} ({1})",
            //      aGroup.Key, aGroup.Count());
            //    foreach (var item in aGroup)
            //        Console.WriteLine("    " + item);
            //}

            #endregion

            #region Query 8
            //var r8 = from p
            //         in persons
            //         where p.Country == "US"
            //         select p.Name;
            //foreach(var p in r8)
            //{
            //    Console.WriteLine(p);
            //}

            #endregion

            #region Query 9

            //int[] numbers = { 2, 3, 4, 5 };
            ////the following returns a query of type IEnumerable<a>
            //var r9 =
            //from x in numbers
            //select new { Radius = x, Area = Math.PI * x * x };
            //foreach(var x in r9)
            //{
            //    Console.WriteLine(x);
            //}


            #endregion

            #region Query 10

            //var r10 = from p in persons
            //         where p.Asset > 50
            //         select p;
            //foreach (var p in r10)
            //{
            //    Console.WriteLine(p);
            //}
            #endregion





        }
    }
}
