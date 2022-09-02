using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question19
    {
        public static void Main19()
        {
            int num, i, j, k;
            int count = 1;
            Console.Write("enter the level:");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(count);
                    count = count + 1;
                    Console.Write(" ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
