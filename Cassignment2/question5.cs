using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question5
    {
        public static void Main5()
        {
            Console.WriteLine("Enter the Age");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if(num1<0)
            {
                Console.WriteLine("The data you entered is corrupt");
            }
            else if (num1 >= 18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");

            }
            else
            {
                Console.WriteLine("Sorry! You are not eligible for casting your vote.");

            }
            
            Console.ReadKey();
        }
    }
}
