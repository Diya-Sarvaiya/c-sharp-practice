using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_methods
{
    class Stack
    {

        public void AllStackMethods()
        {
            Stack<string> s1 = new Stack<string>();

            // push
            s1.Push("diya");
            s1.Push("devanshu");
            s1.Push("priyal");
            Console.WriteLine("push : \n"+String.Join("\n", s1));

            //pop
            string i1 = s1.Pop();
            Console.WriteLine("\npop : "+"poped item : "+i1+"\n stack : \n" + String.Join("\n", s1));

            //peek
            Console.WriteLine("\nPeek : " + s1.Peek());

            //Contains(string item)
            Console.WriteLine("\n Contains : "+s1.Contains("diya"));

            // clear
            /*s1.Clear();*/
            Console.WriteLine("\n clear : "+String.Join("/n",s1));

            // Count
            Console.WriteLine("\n count : " + s1.Count);

        }

    }
}
