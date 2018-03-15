using System;

namespace StockError
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....

            try
            {
                StockItem i = new StockItem(-1);
            }
            catch (StockItemException ex)
            {
                Console.WriteLine("Stockitem error [" + ex.Message + "]. Forkert værdi er " + ex.WrongValue.ToString());                
            }
            catch (Exception ex)
            {
                Console.WriteLine("All other error");
            }

            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

     class StockItem
      {

        public int ID { get; set; }


        public StockItem(int id)
        {
            if (id < 0)
                throw new StockItemException("Værdien er forkert",id);
            this.ID = id;
        }




    }

    class StockItemException : Exception
    {

        public int WrongValue { get; set; }

        
        public StockItemException(string message,int wrongvalue) : base(message)
        {
            WrongValue = wrongvalue;
        }

    }
}
