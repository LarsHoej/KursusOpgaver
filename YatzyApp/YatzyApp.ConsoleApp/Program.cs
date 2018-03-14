using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YatzyApp.Core;


namespace YatzyApp.Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Dice d;
            d = new Dice(7);
            System.Console.WriteLine(d.DiceVal());
            d.RollDice();
            System.Console.WriteLine(d.DiceVal());
            


        }
    }
}
