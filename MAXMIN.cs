using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    public class minmax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nInput first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third number:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));
        }
    }
}
