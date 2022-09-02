
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question7
    {
        public static void Main7()
        {
            Console.WriteLine("Enter the height");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if(num1<0)
            {
                Console.WriteLine("Corrupt data,enter the data properly");
            }
            else if (num1 < 150)
            {
                Console.WriteLine("The Person is Dwarf");
            }
            else if (num1 == 150)
            {
                Console.WriteLine("The Person has Average Height");

            }
            else
            {
                Console.WriteLine("The person is Tall");

            }

            Console.ReadKey();
        }
    }
}
