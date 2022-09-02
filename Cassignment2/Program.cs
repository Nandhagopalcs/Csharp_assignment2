using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the first Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1==num2)
            {
                Console.WriteLine(num1 + " and " + num2 + " are same");
            }
            else
            {
                Console.WriteLine(num1 + " and " + num2 + " are  not same");
            }
            Console.ReadKey();
        }
    }
}
