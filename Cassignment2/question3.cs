using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question3
    {
        public static void Main3()
        {
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1>=0)
            {
                Console.WriteLine(num1 + ": is Positive");
            }
            else
            {
                Console.WriteLine(num1 + ": is Negative");
            }
            Console.ReadKey();
        }
    }
}
