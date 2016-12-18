using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton14_05
{
    class SampleAttribute : Attribute
    {
        internal readonly string Name;
        internal SampleAttribute(string name)
        {
            this.Name = name;
        }
    }

    class Program
    {
        [Sample("Taro")]
        public static void Sample()
        {
            Console.WriteLine("This is a sample.");
        }

        static void Main(string[] args)
        {
            foreach(var n in typeof(Program).GetMethods())
            {
                foreach(var m in n.GetCustomAttributes(typeof(SampleAttribute), false))
                {
                    Console.WriteLine(((SampleAttribute)m).Name);
                }
            }

            Console.ReadLine();
        }
    }
}
