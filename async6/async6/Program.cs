using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace async6
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Begin main");
                DoWorkAsync();
                Console.WriteLine("Continue Main");

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Main");
                }
                Console.WriteLine("End main");
                Console.ReadLine();
            }

            static async Task DoWorkAsync()
            {
                Console.WriteLine("Begin async");
                await Task.Run(() => DoWork());
                Console.WriteLine("End Async");
            }

            static void DoWork()
            {
                int j = 0;
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("DoWork");
                }
            }

        
    }
}
