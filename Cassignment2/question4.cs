using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question4
    {
        public static void Main4()
        {
            Console.WriteLine("Enter the Year");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1%100==0)
            {
                if(num1%400==0)
                {
                    Console.WriteLine(num1 + " is a Leap year");
                }
                else
                {
                    Console.WriteLine(num1 + " is not a Leap year");
                }
            }
            else
            {
                if (num1 % 4 == 0)
                {
                    Console.WriteLine(num1 + " is a Leap year");
                }
                else
                {
                    Console.WriteLine(num1 + " is not a Leap year");
                }
            }
            Console.ReadKey();
        }
    }
}
