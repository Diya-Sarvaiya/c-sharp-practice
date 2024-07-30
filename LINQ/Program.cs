using System;
using System.Collections;
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

            Console.WriteLine("min : " + min);
            Console.WriteLine("max : " + max);
            Console.WriteLine("avg : " + avg);
            Console.WriteLine("count : " + count);
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("---");

            var h = a.Aggregate((total, x) => { return total + x; });
            Console.WriteLine(h);
            Console.WriteLine("---");


            Employee e1 = new Employee();
            List<Employee> g = e1.getEmployee().ToList();
            g.ForEach(x => Console.WriteLine(x.Name));
            Console.WriteLine("---");

            // OrderBy operator

            List<Employee> f = e1.getEmployee().Where(x => x.Salary > 65000).OrderBy(x => x.Salary).ToList();
            f.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");
            // OrderByDescending operator

            List<Employee> l = e1.getEmployee().Where(x => x.Salary > 65000).OrderByDescending(x => x.Salary).ToList();
            l.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");

            // ThenBy operator

            List<Employee> m = e1.getEmployee().Where(x => x.Salary > 65000).OrderBy(x => x.Salary).ThenBy(x => x.Name).ToList();
            m.ForEach(x => Console.WriteLine("Name : " + x.Name + " - Salary : " + x.Salary));
            Console.WriteLine("---");

            // ThenByDescending operator

            List<Employee> n = e1.getEmployee().Where(x => x.Salary > 65000).OrderByDescending(x => x.Salary).ThenBy(x => x.Name).ToList();
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

            var q = e1.getEmployee().TakeWhile(x => x.HireDate > new DateTime(2018, 11, 30)).ToList();
            q.ForEach(x => Console.WriteLine($"Name : {x.Name} - Salary : {x.Salary}"));
            Console.WriteLine("---");

            // skip

            var k = e1.getEmployee().Skip(3).ToList();
            k.ForEach(x => Console.WriteLine($"Name : {x.Name} - Salary : {x.Salary}"));
            Console.WriteLine("---");

            //ToArray Method

            List<string> arr = new List<string> { "a", "b", "c" };
            string[] arr2 = arr.ToArray();
            arr2[0] = "d";
            foreach (string i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");
            foreach (string i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");

            //ToLookup

            Employee e2 = new Employee();
            var lp = e2.getEmployee().ToLookup(x => x.Department, x => x);
            foreach (var i in lp)
            {
                Console.WriteLine("key : " + i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine("Name : " + j.Name + " Salary : " + j.Salary);
                }
            }
            Console.WriteLine("---");

            // group by

            var grouped = e2.getEmployee().GroupBy(x => x.Department).ToList();
            foreach (var gp in grouped)
            {
                Console.WriteLine("- Department - " + gp.Key);
                foreach (var item in gp)
                {
                    Console.WriteLine($"Name - {item.Name} - Salary - {item.Salary} ");
                }
            }
            Console.WriteLine("---");

            // Cast

            List<object> b1 = new List<object> { 3, 5, 7 };
            ArrayList al = new ArrayList { "hello", "hola", "annyonghaseyo" };
            IEnumerable<string> c2 = al.Cast<string>();
            IEnumerable<int> c1 = b1.Cast<int>();
            foreach (var i in c2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");
            foreach (var i in c1)
            {
                Console.WriteLine(i);
            }

            //OfType

            ArrayList d1 = new ArrayList { "Diya", 45.78f, "priyal", 89, "devanshu", "lol", "move", 12, 56, 100.0f };
            IEnumerable<string> s1 = d1.OfType<string>();
            IEnumerable<int> f1 = d1.OfType<int>();
            IEnumerable<float> g1 = d1.OfType<float>();

            foreach (var i in s1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");

            foreach (var i in f1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");

            foreach (var i in g1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");

            // AsEnumrable 

            List<string> h1 = new List<string> { "hello", "how", "are", "you" };
            IEnumerable<string> i1 = h1.AsEnumerable();
            foreach (var i in i1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---");

            // AsDictonary 

            Dictionary<int, string> j1 = e2.getEmployee().ToDictionary(x => x.Id, x => x.Name);
            foreach (var i in j1)
            {
                Console.WriteLine(" key : " + i.Key + " - value : " + i.Value);
            }
            Console.WriteLine("---");

            // Element Operator
            // First 
            /**/
            List<string> k1 = new List<string>
            {
                "this is a first Line",
                "this is a second Line",
                "this is a third Line",
                "this is a Last Line"
            };
            Console.WriteLine(k1.First());
            Console.WriteLine(k1.FirstOrDefault());
            Console.WriteLine(k1.Last());
            Console.WriteLine(k1.LastOrDefault());
            Console.WriteLine(k1.ElementAt(1));
            Console.WriteLine(k1.ElementAtOrDefault(2));
            /*Console.WriteLine(k1.Single(x=>x == "this is a first Line"));
           Console.WriteLine(k1.SingleOrDefault(x => x == "this is a second Line"));*/

            int[] k2 = { 1,2,3};
            foreach (var i in k2.DefaultIfEmpty())
            {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }

    }

}
