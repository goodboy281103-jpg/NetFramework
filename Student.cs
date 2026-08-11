using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_AccessModifiers
{
    internal class Student
    {
       
            public string name = "Aditya";
            private int Age = 22;
            protected string Department = "MCA";
            internal Double CGPA = 9.2;
            protected internal string College = "GLA University";
            private protected string Address = "Mathura";

            public void Display()
            {
                Console.WriteLine("Student Details");
                Console.WriteLine("__________________");
                Console.WriteLine("NAME:" + name);
                Console.WriteLine("AGE:" + Age);
                Console.WriteLine("DEPARTMENT:" + Department);
                Console.WriteLine("CGPA:" + CGPA);
                Console.WriteLine("COLLEGE:" + College);
                Console.WriteLine("ADDRESS:" + Address);

            }
            static void Main(string[] args)
            {
            Student s = new Student();
            s.Display();

            }





        }

    }








        

    






