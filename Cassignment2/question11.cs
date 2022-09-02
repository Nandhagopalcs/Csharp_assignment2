using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question11
    {
        public static void Main11()
        {
            Console.WriteLine("Enter the Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num1;i++)
            {
                Console.WriteLine("Number is : "+i+" and cube of the "+ i+" is : "+i*i*i);
            } 
            Console.ReadKey();
        }
    }
}
