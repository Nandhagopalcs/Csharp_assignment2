using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question12
    {
        public static void Main12()
        {
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine(num1+"*"+i+"="+num1*i);
            }
            Console.ReadKey();
        }
    }
}
