using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton14_03
{

    class SampleAttribute : Attribute { }

    class Program
    {
        [Sample]
        public static void oldSample()
        {
            Console.WriteLine("This is a sample.");
        }

        static void Main(string[] args)
        {
            oldSample();

            Console.ReadLine();
        }
    }
}
