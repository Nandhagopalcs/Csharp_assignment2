using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question8
    {
        public static void Main8()
        {
            Console.WriteLine("Enter the first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third Number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("First Number is greatest among three");
                }
                else
                {
                    Console.WriteLine("Third Number is greates among three ");
                }
            }
            else
            {
                if(num2>num3)
                {
                    Console.WriteLine("Second Number is greatest among three");
                }
                else
                {
                    Console.WriteLine("Third Number is greatest among three");
                }
            }
            Console.ReadKey();

        }
    }
}
