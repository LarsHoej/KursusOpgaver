﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpgVariable
{
    class Program
    {
        struct Person
        {
            public int id;
            public string navn;
        }

        static void Main(string[] args)
        {

            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;

            Console.WriteLine(heltal);


            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;

            Console.WriteLine(kommatal);

            Filtyper ft = Filtyper.csv;
            Console.WriteLine((int)ft);

            DateTime datetime = DateTime.Now;
            Console.WriteLine(datetime.ToString("ddMMyy"));
            Console.WriteLine(datetime.ToString("dMy"));

            Person p = new Person();
            p.id = 1;
            p.navn = "Mikkel";

            Console.WriteLine(p.navn);
    }
    }
    public enum Filtyper { csv, pdf, txt };

   


}