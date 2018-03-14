using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzyApp.Core
{
    public class Dice
    {

        private static System.Random rnb = new Random();

        // Felt
        private int value;

        public int Value {
              get { return this.value; }
              private set {
                if (value < 1 || value > 6)
                    this.value = 1;
                else
                  this.value = value; }
        }
        public string DiceVal()
        {
            return "[" + this.value + "]";
        }

        public Dice()
        {

            this.RollDice();
        }

        public Dice(int value)
        {
            
            this.Value = value;
        }

        public void RollDice()
        {
            this.Value = rnb.Next(1, 7);
        }
    }
}
