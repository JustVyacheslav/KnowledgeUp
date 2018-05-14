using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace UpMyKnowlege
{

    class Program
    {
        static void Main(string[] args)
        {
            Format format = new Format(25);
            Console.WriteLine("{0:M3}", format);

            Yield m = new Yield();
            foreach (int k in m)
                Console.Write("{0} ", k);
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}
