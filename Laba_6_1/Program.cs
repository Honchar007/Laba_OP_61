using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rhombus rhombus = new Rhombus(12, 13,false,60);
            Console.WriteLine(rhombus.GetSquare());
            Console.ReadLine();
        }
    }
}
