using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cassignment2
{
    internal class question10
    {
        public static void Main10()
        {

            Console.WriteLine("Enter the Maths Marks");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Physics Marks");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Chem Marks");
            int chem = Convert.ToInt32(Console.ReadLine());
            if(math+phy+chem>=180 && math>=65 &&phy>=55&& chem>=50)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else if(math+phy+chem >=140 &&math>=65)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
            Console.ReadKey();
        }
    }
}
