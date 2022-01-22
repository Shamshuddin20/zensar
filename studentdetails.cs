using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class studentdetails
    {
        static void Main()
        {
            float sum = 0.0f;
            float avg;
            float[] arr = new float[10];
            Console.WriteLine("enter the marks:");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("marks{0}", i + 1);
                arr[i] = Convert.ToSingle(Console.ReadLine());
            }
            float min = arr[0], max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
            avg = sum / arr.Length;
            Console.WriteLine("total:" + sum);
            Console.WriteLine("average:" + avg);
            Console.WriteLine("min:{0} max:{1}", min,max);
            Array.Sort(arr);
            Console.WriteLine("ascending order----");
            foreach(var marks in arr)
            {
                Console.WriteLine(marks);
            }
            Array.Reverse(arr);
            Console.WriteLine("descending order----");
            foreach(var marks in arr)
            {
                Console.WriteLine(marks);
            }
        }
    }
}
