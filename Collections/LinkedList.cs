using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_methods
{
    class LinkedList
    {
        public void AllLinkedListMethods()
        {
            LinkedList<string> l1 = new LinkedList<string>();

            // AddFirst
            l1.AddFirst("from");
            l1.AddFirst("world");
            l1.AddFirst("hello");
            Console.WriteLine("AddFirst : "+String.Join(" -> ",l1));

            // AddLast
            l1.AddLast("weybee");
            Console.WriteLine("AddLast : "+String.Join(" -> ", l1));

            // First
            Console.WriteLine("First : " + l1.First.Value);

            // Last
            Console.WriteLine("Last : " + l1.Last.Value);

            // next
            Console.WriteLine("Next : " + l1.First.Next.Value);


            // AddBefore
            LinkedListNode<string> node1 = l1.First.Next.Next.Next;
            l1.AddBefore(node1, "say");
            Console.WriteLine("AddBefore : " + String.Join(" -> ", l1));

            // AddAfter
            LinkedListNode<string> node2 = l1.Find("weybee");
            l1.AddAfter(node2, "solutions");
            Console.WriteLine("AddAfter : " + String.Join(" -> ", l1));

            // AddAfter
            LinkedListNode<string> node3 = l1.Find("solutions");
            l1.AddAfter(node3, "solutions");
            Console.WriteLine("AddAfter : " + String.Join(" -> ", l1));

            //FindLast
            Console.WriteLine("FindLast : " + l1.FindLast("solutions").Value);

            // Remove
            l1.Remove("solutions");
            Console.WriteLine("Remove : "+String.Join(" -> ",l1));

            // RemoveFirst
            l1.RemoveFirst();
            Console.WriteLine("RemoveFirst : " + String.Join(" -> ", l1));

            // Removelast
            l1.RemoveLast();
            Console.WriteLine("RemoveLast : " + String.Join(" -> ", l1));
            Printlist(l1);

            //clear 
       /*     l1.Clear();*/

            void Printlist(LinkedList<string> list)
            {
                foreach(string node in list)
                {
                    Console.Write(" -> " + node);
                }
                Console.WriteLine();
            }
        }
    }
}
