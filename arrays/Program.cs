using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] male= { "Maaz", "sami", "Faisal" };

            Console.WriteLine("----------- 1st Program printing names using Arrays------------- " + "\n" );
            for (int i = 0; i < male.Length; i++)
            {
                Console.WriteLine(male[i]);
            }


            Console.WriteLine("\n" + "-----------2nd Program Printing Even & Odd Numbers-----------------:" +"\n"  );

            int [] evenno = { 2, 5, 7, 8, 10, 12, 15, 16, 18, 19, 22, };

            for (int i = 0; i < evenno.Length; i++)
            {
                if (evenno[i] % 2 == 0)
                {
                    Console.WriteLine("Even Number:" + evenno[i]);
                }
                else
                {
                    Console.WriteLine("Odd Numbers:" + evenno[i]);
                }
            }

            int[] leapyear = { 2000, 2002, 2004, 2010, 2014, 2015, 2020, 2022 };

            Console.WriteLine("\n" + "---------------Leap Year Program ---------" + "\n");

            for (int i = 0; i <leapyear.Length; i++)
            {
                if (leapyear[i] % 4 == 0)
                {
                    Console.WriteLine("Its Leap Year !!" + leapyear[i]);
                }
                else
                {
                    Console.WriteLine( "Its Normal year:" + leapyear[i]);
                }
            }

            Console.WriteLine("---------------------Prime Number Program ----------------------");

            

            Console.ReadKey();
        }
    }
}
