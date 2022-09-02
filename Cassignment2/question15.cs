using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question15
    {
        public static void Main15()
        {
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            for(int i=0;i<num1;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
