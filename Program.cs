using System;

class program
{


    delegate void MyDelegate(int a, int b);


    static void CalculateSum(int a, int b)

    {
         
        int sum = a + b;

        Console.WriteLine("Sum =" + sum);

    }

        static void Main()

        { 

        MyDelegate obj = new MyDelegate(CalculateSum);

        obj(10, 20);

    }


}








    





