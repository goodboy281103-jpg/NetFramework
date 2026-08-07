using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcaproject_1
{
    internal class PROGRAM4
    {

        static void Main(string[] args)
        {
            Console.Write("Enter student marks (0-100): ");
            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {

                Console.WriteLine("Invalid marks! Please enter marks between 0 and 100.");
            }
            else if (marks >= 91)
            {
                Console.WriteLine("Grade: O");
            }
            else if (marks >= 81)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (marks >= 71)
            {
                Console.WriteLine("Grade: A");
            }
            else if (marks >= 61)
            {
                Console.WriteLine("Grade: B+");
            }
            else if (marks >= 51)
            {
                Console.WriteLine("Grade: B");
            }
            else

            {


                Console.WriteLine("Grade: Fail");
            }


            {


            }


        }
    }

}
    











        


    


            


            
        
                
    






































