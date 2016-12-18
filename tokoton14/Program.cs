using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
     
     

namespace tokoton14
{
    class Program
    {
        [Conditional("DEBUG")]
        private static void debugDump()
        {
            Console.WriteLine("Thia is a debug version.");
        }

        static void Main(string[] args)
        {
            debugDump();
            Console.WriteLine("Hello");

            Console.ReadLine();
        }
    }
}
