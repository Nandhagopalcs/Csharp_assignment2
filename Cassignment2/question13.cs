using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question13
    {
        public static void Main13()
        {
            Console.WriteLine("Enter the Number(range 1 to 8)");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for(int j=1;j<=num1;j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(j + "*" + i + "=" + j * i+"  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
