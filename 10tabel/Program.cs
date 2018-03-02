using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    tal = i * j;
                    if (tal > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write(tal.ToString().PadLeft(5));
                }
                Console.WriteLine("");

            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

        }



    }
}
