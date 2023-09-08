using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap01_LM
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte a = -100;
            SByte a2 = -101;
            SByte f = Math.Max(a, a2);
            Console.WriteLine(f);
        }
    }
}
