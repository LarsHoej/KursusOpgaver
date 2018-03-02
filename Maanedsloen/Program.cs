using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maanedsloen
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] maanedsloen = { 23000, 45000, 67000, 18000, 42000 };
            double gns = 0;
            double sum = 0;

            System.Array.Sort(maanedsloen);

            for (int i = 0; i < maanedsloen.Length; i++)
            {
                Console.WriteLine(maanedsloen[i].ToString());
                sum += maanedsloen[i];
            }

            gns = sum / maanedsloen.Length;
            
            Console.WriteLine(gns.ToString("N2"));

            
        }
    }
}
