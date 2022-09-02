using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question16
    {
        public static void Main16()
        {
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=num1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
