using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question18
    {
        public static void Main18()
        {
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            for (int i = 1; i <= num1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count = count + 1;
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
