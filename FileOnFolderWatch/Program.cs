using System;

namespace FileOnFolderWatch
{
    class Program
    {
        static void Main(string[] args)
        {


            // Your code here.....



            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += ChangedEvent;
            // eller
            w.Changed += (s, e) => { Console.WriteLine(e.FullPath); };


            System.IO.FileSystemWatcher w2 = new System.IO.FileSystemWatcher(@"c:\git", "*.txt");
            w2.EnableRaisingEvents = true;
            w2.Changed += ChangedEvent;
            


            do
            {

            } while (true);


            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void ChangedEvent(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.FullPath);
        }
    }
}
