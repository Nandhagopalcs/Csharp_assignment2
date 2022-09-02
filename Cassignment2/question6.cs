using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question6
    {
        public static void Main6()
        {
            Console.WriteLine("Enter the Value of M");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 < 0)
            {
                Console.WriteLine("The value of n is -1");
            }
            else if (num1 == 0)
            {
                Console.WriteLine("The value of n is 0");

            }
            else
            {
                Console.WriteLine("The value of n is 1");

            }

            Console.ReadKey();
        }
    }
}
