using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class arraysminmax
    {
        static void Main(string[] args)
        {
            int[] marks = { 55, 22, 33, 44, 11 };
            float sum = 0.0f;
            int min=marks[0];
            int max=marks[1];   
            foreach(var item in marks)
            {
                sum += item;
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }

            Console.WriteLine("average of array elements:" +(sum/marks.Length));
            Console.WriteLine("largest of array elements:" + max);
            Console.WriteLine("smallest of array elements:" + min);

        }

    }
}
