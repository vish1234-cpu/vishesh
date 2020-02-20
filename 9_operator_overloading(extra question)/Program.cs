using System;

namespace operator_overloading // overloading of unary operator "-". 
{
    class Reverse 
    {

        public int n1, n2;
        public Reverse(int num1, int num2) 
        {
            n1 = num1;
            n2 = num2;
        }

        // Function to perform operation 
        // By changing sign of integers 
        public static Reverse operator -(Reverse r) // syntax for overlaoding an operator. 
        {
            r.n1 = -r.n1;
            r.n2 = -r.n2;
            return r;
        }

        // Function to print the numbers 
        public void Print()
        {
            Console.WriteLine("Number1 = " + n1);
            Console.WriteLine("Number2 = " + n2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // using overloaded - operator  
            // with the class object 
            Reverse rev = new Reverse(15, -25); // this will reverse the sign of integers. 

            rev = -rev;

            // To display the result 
            rev.Print(); 
        }
    }
}
