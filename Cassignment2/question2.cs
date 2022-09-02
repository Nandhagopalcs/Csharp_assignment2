using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question2
    {
        public static void Main2()
        {
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1%2==0)
            {
                Console.WriteLine(num1+": is even");
            }
            else
            {
                Console.WriteLine(num1+": is odd");
            }
            Console.ReadKey();
        }
    }
}
