using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class temp
    {
        static void Main()
        {
            Console.WriteLine("enter the temp:");
            double fah=Convert.ToDouble(Console.ReadLine());

            double cel = (fah - 32) * 5 / 9;
            Console.WriteLine($"The temperature in celsius:{cel}");

        }
    }
}
