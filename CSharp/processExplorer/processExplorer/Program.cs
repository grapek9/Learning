using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process Explorer");
            Process[] processArray = Process.GetProcesses();
            foreach (Process currentProcess in processArray)
            {
                Console.WriteLine("Process ID:"+currentProcess.Id+" Name:"+currentProcess.ProcessName);
                //Console.WriteLine(currentProcess.Threads);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
