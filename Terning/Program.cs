using System;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            Terning t1;
            t1 = new Terning();

            Console.WriteLine(t1.V�rdi.ToString());

            Terning t2;
            t2 = new Terning(6);
            Console.WriteLine(t2.V�rdi.ToString());

            t2 = t1;
            Console.WriteLine(t1.V�rdi.ToString());
            Console.WriteLine(t2.V�rdi.ToString());




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }



    public class Terning
    {
        public int V�rdi;

        public Terning()
        {
            V�rdi = 1;
        }

        public Terning(int V�rdi)
        {
            this.V�rdi = V�rdi;
        }

    }
}

