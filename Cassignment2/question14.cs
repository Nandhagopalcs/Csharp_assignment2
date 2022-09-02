using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question14
    {
        public static void Main14()
        {
            Console.WriteLine("number of terms");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 1;
            Console.Write("The odd numbers are: ");
            int sum = 0;
            while(count<num1)
            {
                if(i%2!=0)
                {
                    Console.Write(i+ " ");
                    sum = sum + i;
                    count = count + 1;
                }
                i = i + 1;
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of odd Natural Number upto" + num1 + " terms : " + sum);
            Console.ReadKey();
        }
    }
}
