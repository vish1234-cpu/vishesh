using System;

namespace Leapyear_ques2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 4 digit year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year%400==0)
            {
                Console.WriteLine("Leap Year");
            }
            else if (year%100==0)
            {
                Console.WriteLine("Not A Leap Year");
            }
            else if (year%4==0)
            {
                Console.WriteLine("Leap Year");
            }
        }
    }
}
