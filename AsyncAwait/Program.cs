using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {

            summonDog();
            Console.ReadKey();

        }
        static async Task summonDog()
        {
            string path = "D:/C#/AsyncAwait/dog.txt";
            Console.WriteLine("Dog File loading ...");
            try
            {
                using (FileStream filestream = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(filestream))
                    {
                        string content = await streamReader.ReadToEndAsync();
                        Console.WriteLine(content);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

        }


    }
}
