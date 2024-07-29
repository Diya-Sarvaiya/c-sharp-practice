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
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Methods Syntax

            var b = from x in a where x > 5 select x;
            foreach (var i in b)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");

            // Query Syntax

            var d = a.Where(x => x < 5).ToList();
            d.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---");


            // Aggregate Functions

            var min = a.Min();
            var max = a.Max();
            var avg = a.Average();
            var count = a.Count();
            var sum = a.Sum();

            Console.WriteLine("min : "+min);
            Console.WriteLine("max : " + max);
            Console.WriteLine("avg : " + avg);
            Console.WriteLine("count : " + count);
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("---");

            var h = a.Aggregate((total,x) => { return total + x; });
            Console.WriteLine(h);
            Console.WriteLine("---");


            Employee e1 = new Employee();
            List<Employee> g = e1.getEmployee().ToList();
            g.ForEach(x => Console.WriteLine(x.Name));
            Console.WriteLine("---");

            // OrderBy operator

            List<Employee> f = e1.getEmployee().Where(x=>x.Salary>65000).OrderBy(x=>x.Salary).ToList();
            f.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");
            // OrderByDescending operator

            List<Employee> l = e1.getEmployee().Where(x => x.Salary > 65000).OrderByDescending(x => x.Salary).ToList();
            l.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");

            // ThenBy operator

            List<Employee> m = e1.getEmployee().Where(x => x.Salary > 65000).OrderBy(x => x.Salary).ThenBy(x=>x.Name).ToList();
            m.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");

            // ThenByDescending operator

            List<Employee> n = e1.getEmployee().Where(x => x.Salary > 65000).OrderByDescending(x => x.Salary).ThenBy(x=>x.Name).ToList();
            n.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");

            // reverse operator
            var o = e1.getEmployee().Reverse().ToList();
            o.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");

            // Take

            var p = e1.getEmployee().Take(2).ToList();
            p.ForEach(x => Console.WriteLine($"Name : {x.Name} - Salary : {x.Salary}"));
            Console.WriteLine("---");

            // Take While

            var q = e1.getEmployee().TakeWhile(x=>x.HireDate > new DateTime(2018, 11, 30)).ToList();
            q.ForEach(x => Console.WriteLine($"Name : {x.Name} - Salary : {x.Salary}"));
            Console.WriteLine("---");

            // skip

            var k = e1.getEmployee().Skip(3).ToList();
            k.ForEach(x => Console.WriteLine($"Name : {x.Name} - Salary : {x.Salary}"));
            Console.WriteLine("---");
            Console.ReadKey();
        }
      
    }

}
