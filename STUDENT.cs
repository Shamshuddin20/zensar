using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of students");
            int num=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<5;i++)

            {
                Console.WriteLine("enter the marks of the student{i+1}");
                
                Console.WriteLine("enter the marks of c#");
                float s1=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter the marks of html");
                float s2=Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter the marks of sql");
                float s3=Convert.ToSingle(Console.ReadLine());

                double avg = (s1 + s2 + s3) / 3;
                if(avg>50)
                {
                    Console.WriteLine("Student passed");
                }
                else
                {
                    Console.WriteLine("Student failed");
                }

            }
        }
    }
}
