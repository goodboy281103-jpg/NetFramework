using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcaproject_1
{
    internal class PROGRAM2
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Num 1");
            int NUM1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num 2");
            int NUM2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of Two Numbers is:" + (NUM1 + NUM2));

            Console.WriteLine("Difference is" + (NUM1 - NUM2));
            Console.WriteLine("Product is:" + (NUM1 * NUM2));
            Console.WriteLine("Quotient is:" + (NUM1 / NUM2));
            Console.WriteLine("Remainder is:" + (NUM1 % NUM2));

        }
    }
}
