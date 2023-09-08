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
            decimal a = 23.97M;
            decimal f = Math.Truncate(a);
            Console.WriteLine(f);
        }
    }
}
