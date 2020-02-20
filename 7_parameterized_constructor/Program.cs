using System;

namespace parameterized_constructor
{

    class baseclass  // base class is created.
    {
        public baseclass() // this is a default constructor.
        {
            Console.WriteLine("I am Default Constructors");
        }
        public baseclass(string message) // this is a parameterized constructor. 
        {
            Console.WriteLine("Constructor Message : " + message);
        }
    }

    class childclass : baseclass // inheritance is achieved. 
    { 
        public childclass()
        {
        }
        public childclass(string message) //  parameterised constructor is called from the derived class. 
            : base(message)
        {
        }
    }
        class Program
    {
        static void Main(string[] args)
        {

                childclass ch = new childclass(); // calling the default constructor. 
                childclass ch1 = new childclass("Hello Constructor"); // calling the parameterised constructor. 
                Console.ReadKey();




            }
    }
}
