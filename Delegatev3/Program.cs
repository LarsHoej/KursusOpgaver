using System;

namespace Delegatev3
{

   
    public class maskine
    {

        public Action<string> Log { get; set; }

        public void Start()
        {
            string s = System.DateTime.Now.ToLongTimeString() + " starter";
            Log(s);
        }

        public void Slut()
        {
            string s = System.DateTime.Now.ToLongTimeString() + " slutter";
            Log(s);
        }

    }

    class Program
    {

        //static void AppendLog(string txt)
        //{
        //    System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        //}

        static void Main(string[] args)
        {


            // Your code here.....

            maskine m = new maskine();
            m.Log = (string txt) => { Console.Write(txt); Console.WriteLine(); };
            m.Log += (string txt) => { System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n"); };
            m.Start();
            m.Log -= Console.WriteLine;
            m.Slut();
            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
