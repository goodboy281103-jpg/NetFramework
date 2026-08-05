using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mcaproject_1
{
    internal class Program 
    {
        static void Main1(string[] args)
        {
            int rollno;
            string name;
            float marks;

            Console.Write("Enter Student Name");
             name = Console.ReadLine();

            Console.Write("Enter Student Roll  Number");
             rollno = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter Student Marks");
             marks = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n---Student Details---");
            Console.WriteLine("student Name:" + name);
            Console.WriteLine("student Roll number:" + rollno);
            Console.WriteLine("student Marks:" + marks);


        }

     
    }
}
