using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'I', 'J', 'K', 'L' };
            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = 0; j <= i; j++)
                {
                    Console.Write(arr[j]);
                }

                for (j = i; j > 0; j--)
                {
                    Console.Write(arr[j - 1]);
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
