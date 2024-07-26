using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_methods
{
    class List
    {
        public void allListMethods()
        {
            /*List Methods*/

            /* Add */

            List<int> l1 = new List<int>();
            l1.Add(1);
            for (int i = 1; i <= 3; i++)
            {
                l1.Add(i * 10);
            }
            Console.WriteLine("Add : " + String.Join(",", l1));

            /* AddRange */

            l1.AddRange(new int[] { 40, 50, 60 });
            Console.WriteLine("AddRange : " + String.Join(",", l1));

            /* BinarySearch */

            int n = l1.BinarySearch(50);
            Console.WriteLine("BinarySearch : " + n);

            /* Clear */

            /*l1.Clear();*/
            Console.WriteLine("Clear : " + String.Join(",", l1));

            /* Contains */
            /* used to check whether an element is in the List */

            bool a = l1.Contains(40);
            Console.WriteLine("Contains : " + a);

            /* ConvertAll(Converter) */
            /* used to convert all element with Converter */

            List<int> l2 = l1.ConvertAll(x => x * 2);
            Console.WriteLine("ConvertAll : " + String.Join(",", l2));

            /* CopyTo */
            /* parameters list index-2, array name, array index-4, count of elem to copy-4*/
            int[] l3 = new int[15];
            l1.CopyTo(2, l3, 4, 4);
            Console.WriteLine("CopyTo : " + String.Join(",", l3));


            /* Equals */
            /* check if two list is same or not */
            Console.WriteLine("Equals : " + l1.Equals(l3));

            /* Exist */
            /* check if element in list exist or not */
            Console.WriteLine("Exists : " + l1.Exists((e) => e > 50));

            /* Find */
            Console.WriteLine("Find : " + l1.Find((e) => e > 50));

            /* FindAll */
            Console.WriteLine("FindAll : " + String.Join(",", l1.FindAll((e) => e > 30)));

            /* FindIndex */
            Console.WriteLine("FindIndex : " + String.Join(",", l1.FindIndex((e) => e > 30)));

            /* FindLast */
            Console.WriteLine("FindLast : " + String.Join(",", l1.FindLast((e) => e > 30)));

            /* FindLastIndex */
            Console.WriteLine("FindLastIndex : " + String.Join(",", l1.FindLastIndex((e) => e > 30)));

            /* For Each */
            Console.Write("For each : ");
            l1.ForEach((e) => {
                e = e + 5;
                Console.Write(e + ", ");
            });
            /* Console.WriteLine("For each : " + String.Join(",", l1));*/

            /* Get Enumerator */
            Console.WriteLine();
            Console.Write("get enumerator : ");
            List<int>.Enumerator l5 = l1.GetEnumerator();
            while (l5.MoveNext())
            {
                int val = l5.Current;
                Console.Write(val + ", ");
            }

            /* GetHashCode */
            Console.WriteLine();
            int h = l1.GetHashCode();
            Console.WriteLine("GetHashCode : " + h);

            /* GetRange(Int32, Int32) */
            List<int> l6 = l1.GetRange(2, 4);
            Console.WriteLine("GetRange : " + String.Join(",", l6));

            /* GetType */
            Console.WriteLine("GetType : " + l1.GetType());

            /* IndexOf */
            Console.WriteLine("IndexOf : " + l1.IndexOf(30));

            /* Insert */
            l1.Insert(7, 70);
            Console.WriteLine("Insert : " + String.Join(",", l1));

            /* InsertRange */
            l1.InsertRange(8, new int[] { 80, 90 });
            Console.WriteLine("InsertRange : " + String.Join(",", l1));

            /* lastIndexOf */
            Console.WriteLine("lastIndexOf : " + String.Join(",", l1.LastIndexOf(70)));

            /* Remove */
            /* l1.Remove(1);
             Console.WriteLine("Remove : " + String.Join(",", l1));*/

            /* RemoveAll */
            /* l1.RemoveAll((e)=>e%20==0);
             Console.WriteLine("RemoveAll : " + String.Join(",", l1));*/

            /* RemoveAt */
            /* l1.RemoveAt(3);
             Console.WriteLine("RemoveAt : " + String.Join(",", l1));*/

            /* RemoveRange */
            /*  l1.RemoveRange(0,2);
              Console.WriteLine("RemoveRange : " + String.Join(",", l1));*/

            /* Reverse */
            /*l1.Reverse();
            Console.WriteLine("Reverse : " + String.Join(",", l1));*/

            /* Sort */
            l1.Sort();
            Console.WriteLine("Sort : " + String.Join(",", l1));

            /* ToArray */
            int[] a1 = l1.ToArray();
            Console.WriteLine("ToArray : " + String.Join(",", a1));

            /* ToString */
            String s2 = l1.ToString();
            Console.WriteLine("ToString : " + String.Join(",", s2));

            /* Trim Excess */
            Console.WriteLine(l1.Capacity);
            l1.Capacity = 30;
            Console.WriteLine(l1.Capacity);

            l1.TrimExcess();
            Console.WriteLine(l1.Capacity);
            /* Console.WriteLine("TrimExcess : " + String.Join(",", l1));*/

            /*TrueForAll*/
            Console.WriteLine("TrueForAll : " + l1.TrueForAll((e) => e % 2 == 0));
        }
    }
}
