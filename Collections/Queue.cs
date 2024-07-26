using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_methods
{
    class Queue
    {
        public void AllQueueMethods()
        {
            Queue<int> q1 = new Queue<int>();

            // Enqueue
            q1.Enqueue(20);
            q1.Enqueue(40);
            q1.Enqueue(60);
            q1.Enqueue(80);
            q1.Enqueue(100);
            Console.WriteLine("Enqueue : " + String.Join(",", q1));

            // Dequeue
            int i1 = q1.Dequeue();
            Console.WriteLine("Dequeue : " + "item : " + i1 + " Queue : " + String.Join(",", q1));

            // peek
            Console.WriteLine("peek : " + q1.Peek());

            // count
            Console.WriteLine("Count : " + q1.Count);

            // conatains
            Console.WriteLine("Contains : " + q1.Contains(90));

            // clear 
            q1.Clear();
            Console.WriteLine("Clear : "+String.Join(",",q1));
        }
    }
}
