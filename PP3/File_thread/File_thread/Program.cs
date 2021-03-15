using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace File_thread
{
    class Program
    {
        static void Main(string[] args)
        {
            //потік для запису
            //аргумент true вказує на те що в файл не буде записуватись з 0 а буде добавляти новий запис до попереднього
            using (var sw = new StreamWriter("Text.txt", true))
            {
                sw.WriteLine("Hello?");
                //запис з консолі
                string txt;
                do
                {
                    txt = Console.ReadLine();
                    sw.WriteLine(txt);
                }
                while (txt != "");
            }

            //читаєм файл
            using (var sr = new StreamReader("Text.txt"))
            {
                var Text = sr.ReadToEnd();
                Console.WriteLine(Text);
            }
            Console.ReadLine();


        }
    }
}
