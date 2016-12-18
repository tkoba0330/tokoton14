using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton14_04
{

    [AttributeUsage(AttributeTargets.Method)]
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
            foreach(var n in typeof(Program).GetMethods())
            {
                if (n.GetCustomAttributes(typeof(SampleAttribute), false).Length > 0)
                {
                    n.Invoke(null, null);
                }
            }


            Console.ReadLine();
        }
    }
}
