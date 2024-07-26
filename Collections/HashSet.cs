using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_methods
{
    class HashSet
    {
        public void allHashSetMethods()
        {
            Console.WriteLine();

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4,5,6,7,8 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

            Console.WriteLine(" Set1 : " + string.Join(", ", set1));
            Console.WriteLine(" set2 : " + string.Join(", ", set2));

            // Add
            Console.WriteLine("Adding : " + string.Join(", ", set1));

            // Remove
            Console.WriteLine("Remove : " + string.Join(", ", set1)); 

            // Contains 
            Console.WriteLine("Contains : " + set1.Contains(3));

            // Clear 
           /*  set1.Clear();*/
            Console.WriteLine("Clear: " + set1.Count);

            // UnionWith
            set1.UnionWith(set2);
            Console.WriteLine("UnionWith : " + string.Join(", ", set1));

            // IntersectWith
            HashSet<int> set3 = new HashSet<int> { 4, 5, 7, 8 };
            set1.IntersectWith(set3);
            Console.WriteLine("IntersectWith : " + string.Join(", ", set1));

            // ExceptWith
            set1.ExceptWith(new HashSet<int> { 5 });
            Console.WriteLine("ExceptWith : " + string.Join(", ", set1));

            // SymmetricExceptWith
            set1.SymmetricExceptWith(new HashSet<int> { 2, 4, 6 }); 
            Console.WriteLine("SymmetricExceptWith : " + string.Join(", ", set1));

            // IsSubsetOf
            HashSet<int> set4 = new HashSet<int> { 2, 6 };
            Console.WriteLine("IsSubsetOf : " + set4.IsSubsetOf(set1));

            // IsSupersetOf
            HashSet<int> set5 = new HashSet<int> { 2, 6 };
            Console.WriteLine("IsSubsetOf : " + set1.IsSupersetOf(set5));

        }
    }
}
