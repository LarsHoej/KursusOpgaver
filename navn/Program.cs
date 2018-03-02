using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navn
{
    class Program
    {
        static void Main(string[] args)
        {

            string fornavn;
            string efternavn;
            string samletNavn;
            string navnStort;
            string navnlille;
            string del;

            fornavn = "Mikkel";
            efternavn = "Cronberg";

            samletNavn = fornavn + " " + efternavn;

            Console.WriteLine(samletNavn);

            navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);

            navnlille = samletNavn.ToLower();

            Console.WriteLine(navnlille);

            del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);


            string[] navn;

            navn = samletNavn.Split(' ');
            for (int i = 0; i < navn.Length; i++)
            {
                Console.Write(navn[i] + "\r\n");

            }

            System.IO.File.WriteAllText(@"c:\temp\test.txt", samletNavn);


        }

    }
}
