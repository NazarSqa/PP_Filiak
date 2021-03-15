using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace потоки
{
    public class MyTheard
    {

            static void Main(string[] args)
            {
                Thread thread = new Thread(new ThreadStart(DoWork1));
                thread.Start();

                Thread thread2 = new Thread(new ThreadStart(DoWork2));
                thread2.Start();

                Thread thread3 = new Thread(new ParameterizedThreadStart(DoWork3));
                thread3.Start(int.MaxValue);

                int j = 0;
                for (int i = 0; i < int.MaxValue; i++)
                {
                    j++;

                    if (j % 1000 == 0)
                    {
                        Console.WriteLine("Main");
                    }
                }
                Console.ReadLine();
            }

            //потік без параметра
            static void DoWork1()
            {
                int j = 0;
                for(int i = 0; i < int.MaxValue; i++)
                {
                    j++;

                    if (j % 1000 == 0) {
                        Console.WriteLine("THREAD 1");
                    }
                }
            }

            //потік без параметра
            static void DoWork2()
            {
                int j = 0;
                for (int i = 0; i < int.MaxValue; i++)
                {
                    j++;

                    if (j % 1000 == 0)
                    {
                        Console.WriteLine("THREAD 2");
                    }
                }
            }

            //потік з параметром
            static void DoWork3(object max)
                {
                    int j = 0;
                    for (int i = 0; i < (int)max; i++)
                    {
                        j++;

                        if (j % 1000 == 0)
                        {
                            Console.WriteLine("THREAD 3");
                        }
                    }
                }


    }
 }
