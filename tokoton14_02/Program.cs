using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton14_02
{
    class Program
    {
        [Obsolete]
        private static void oldMethod()
        {
            Console.WriteLine("This is a ld version.");
        }

        static void Main(string[] args)
        {
            oldMethod();

            Console.ReadLine();
        }
    }
}
