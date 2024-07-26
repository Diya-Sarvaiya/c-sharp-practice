using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_methods
{
    class Dictionary
    {
        public void AllDictionaryMthods()
        {
            Dictionary<int,string> d1 = new Dictionary<int ,string>();

            // Add
            d1.Add(1, "india");
            d1.Add(2, "will");
            d1.Add(3, "win");
            foreach (int k in d1.Keys)
            {
                Console.WriteLine(k + " : " + d1[k]);
            }
            Console.WriteLine();

            // remove
            Console.WriteLine(d1.Remove(4));
            foreach (int k in d1.Keys)
            {
                Console.WriteLine(k + " : " + d1[k]);
            }
            Console.WriteLine();

            //ContainsKey
            Console.WriteLine("containsKey : "+d1.ContainsKey(1));

            //ContainsValue
            Console.WriteLine("containsValue : " + d1.ContainsValue("india"));

            //GetEnumerator
            Dictionary<int, string>.Enumerator em = d1.GetEnumerator();
            while (em.MoveNext())
            {
                Console.WriteLine(em.Current.Key+" : "+em.Current.Value);
            }


            // sorted Dictionary
            SortedDictionary<string, string> sd1 = new SortedDictionary<string, string>() 
            {
                {"india","Delhi" },
                {"indonesia","Jakarta" },
                {"pakistan","lahore" },
                {"France","paris" },
                {"Japan","Tokio" }
            };

            foreach (var dict in sd1)
            {
                Console.WriteLine(dict.Key+" : "+dict.Value);
            }
          

        }
    }
}
