using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcaproject_1
{
    internal class PROGRAM3
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("num is:" + "Negative");
            }
            else if (num > 0)
            {
                Console.WriteLine("num is:" + "Positive");
            }
            else
            {
                Console.WriteLine("num is:" + "Zero");

            }

            {

            }



        }
    }
}