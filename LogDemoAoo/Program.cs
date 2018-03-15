using NLog;
using System;

namespace LogDemoAoo
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {


            // Your code here.....

            logger.Trace("Enter");
            logger.Debug("Nu kaldes test1");
            test1(5, 5);
            logger.Trace("Retur fra test1");

            logger.Debug("Nu kaldes test2");
            test2();
            logger.Trace("Retur fra test2");

            logger.Trace("Exit");
            

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static void test1(int i, int x)
        {
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                logger.Error("Der kommer en fejl");
                
            }

        }
    }
}
