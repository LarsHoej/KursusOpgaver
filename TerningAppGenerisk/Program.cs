using System;
using System.Collections.Generic;

namespace TerningAppGenerisk
{


    public abstract class Terning
    {
        private static System.Random rnd = new Random();
        public int Værdi { get; private set; }
        public void Ryst()
        {
            Værdi = rnd.Next(1, 7);
        }
        public override string ToString()
        {
            return "[" + this.Værdi + "]";
        }
    }

    public class YatzyTerning : Terning
    {
        public YatzyTerning()
        {
            this.Ryst();
        }
    }

    public class LudoTerning : Terning
    {
        public override string ToString()
        {
            if (this.ErStjerne())
                return "[S]";
            if (this.ErGlobus())
                return "[G]";
            return base.ToString();
        }

        public LudoTerning()
        {
            this.Ryst();
        }

        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        }
    }

    public class Bæger<T> where T : Terning
    {
        private List<T> lst = new List<T>();
        public void Tilføj(T d)
        {
            lst.Add(d);
        }
        public List<T> Terninger()
        {
            return lst;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            YatzyTerning y = new YatzyTerning();
            Console.WriteLine(y);

            LudoTerning l = new LudoTerning();
            Console.WriteLine(l);

            Bæger<LudoTerning> b = new Bæger<LudoTerning>();
            b.Tilføj(new LudoTerning());
            b.Tilføj(new LudoTerning());


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
