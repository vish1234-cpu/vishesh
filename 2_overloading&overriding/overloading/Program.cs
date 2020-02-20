using System;

namespace overloading                          
                                                   // Method Overloading is a feature that allows a class to
                                                  //have more than one method having the same name, 
                                                  //if their argument lists are different. 
{

    class Testoverloading1 
    {

        public int test1(int a, int b)    // method1 with 2 parameters 
        {
            int sum1 = a + b;
            return sum1; 
        }

        public int test1(int a, int b, int c)  // method 2 with 3 parameters. 
        {
            int sum2 = a + b + c;
            return sum2; 
        } 
    }


    class Program
    {
       
        static void Main(string[] args)
        {

            Testoverloading1 obj1 = new Testoverloading1();      // calling of methods. 
            int sum1 = obj1.test1(1, 2);
            int sum2 = obj1.test1(2, 3, 4);

            Console.WriteLine("sum of two integers is" + " "+ sum1);
            Console.WriteLine("sum of three integers is" + " " +  sum2); 
            
        }
    }
}

/*
 Method Overloading is the common way of
 implementing polymorphism. It is the ability
 to redefine a function in more than one form. 
 A user can implement function overloading by 
 defining two or more functions in a class sharing 
 the same name. C# can distinguish the methods with
 different method signatures. i.e. the methods can
 have the same name but with different parameters list. 
 */ 
