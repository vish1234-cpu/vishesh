using System;

namespace typesofmethodoverloading
{

    class Differentdatatypes
    {
        public void show(int a) // method 1 with integer as a parameter 
        {
            Console.WriteLine("integer a is printed:" + a);
        }

        public void show(string a) // method 2 with string as parameter. 
        {
            Console.WriteLine("string a is printed:" + a); 

        } 
    }

    class Differentparameter
    {
        public int add(int a,int b) // function with two parameters.
        {
            int sum = a + b;
            return sum; 
        }

        public int add(int a, int b, int c) // function with three parameters. 
        {
            int sum=a + b + c;
            return sum;  
        }
    }

    class Orderofparameters
    {
        public void showme(int a, string c) // first int parameter then string parameter.
        {
            Console.WriteLine("integer->string is called ");
        }

        public void showme(float d, string c, int a) // order changed first string parameter then integer parameter. 
        {
            Console.WriteLine("string->integer is called "); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Differentdatatypes obj1 = new Differentdatatypes();
            
            obj1.show(10); // here if you write a string inside the show function then string is printed.
                           // initially it is printing the integer i.e 10. 


            Differentparameter obj2 = new Differentparameter();
            int sum = obj2.add(1, 2, 3); // pass 2 parameters to call another function add(int a,int b) 
            Console.WriteLine("The sum is:" + " " + sum);


            Orderofparameters obj3 = new Orderofparameters();
            obj3.showme(10,"hello"); // interchange the order of string and integer to call the function showme(string b, int a).
        }
    }
}
