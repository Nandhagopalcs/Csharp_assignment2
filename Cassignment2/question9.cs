using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question9
    {
        public static void Main9()
        {
            Console.WriteLine("Enter the X value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Y value");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if(num1>0 && num2>0)
            {
                Console.WriteLine("The point is in First quadrant");
            }
            else if(num1>0 && num2<0)
            {
                Console.WriteLine("The point is in Fourth quadrant");
            }
            else if (num1 < 0 && num2 > 0)
            {
                Console.WriteLine("The point is in Second quadrant");
            }
            else if (num1 < 0 && num2 < 0)
            {
                Console.WriteLine("The point is in Third quadrant");
            }
            Console.ReadKey();
        }
    }
}
