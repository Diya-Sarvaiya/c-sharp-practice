using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /* List l = new List();
             l.allListMethods();

             HashSet h = new HashSet();
             h.allHashSetMethods();

             Stack s = new Stack();
             s.AllStackMethods();*/

            Queue q = new Queue();
            q.AllQueueMethods();

            Console.ReadKey();
        }
    }
}
