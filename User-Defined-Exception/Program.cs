using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exception
{
    public class AgeException : Exception
    {
        public AgeException(string Mes) : base(Mes)
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            List<string> nam = new List<string>() { "Alice", "Bob", "Charlie" };
            List<char> firstLetters = nam.ConvertAll(x=>x[0]);
            foreach(char i in firstLetters)
            {
                Console.WriteLine(i);
            }

            var numbers = new List<int>() { 20, 56, 74, 25, 87 };
          
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            List<string> names = new List<string>();
            Console.WriteLine(names.Capacity);
            names.Add("diya");
            names.Capacity = 2;
            names.Add("priyal");
            Console.WriteLine(names.Capacity);
            names.Add("khyati");
            names.Add("devanshu");
            Console.WriteLine(names.Capacity);

            foreach(string i in names)
            {
                Console.WriteLine(i);
            }

           /* try
            {
                int a = 5;
                int n = a / 0;
            }
            catch (Exception e)
            {
                Console.Write(e.TargetSite + "\n");
            }
            finally
            {
                Console.Write("\n");
            }*/

            /*int age = 15;
            try
            {
                if (age < 18)
                {
                    throw new AgeException("Age is less 18");
                }
            }
            catch (AgeException e)
            {
                Console.Write(e.Message);
            }*/

            /*int x = int.MaxValue;   // 2147483647
            int y = 1;

            // This will throw an OverflowException by default
            

            unchecked
            {
                int z = x + y;
                Console.Write(z);
            }*/

            Console.ReadKey();
        }
    }
}
