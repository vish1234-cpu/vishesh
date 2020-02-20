using System;

namespace overiding                       // Method overriding, in object-oriented programming, 
                                          //is a language feature that allows a subclass or child class to provide
                                          //a specific implementation of a method that is already provided by one of 
                                          //its superclasses or parent classes. 
{

    class Testoveriding1 
    {
        public virtual void Test1()                  // method has to be virtual in base class. 
        {
            Console.WriteLine("hello i am base class");
        }
    }

    class Testoveriding2: Testoveriding1
    {
        public override void Test1()                 // override in derived class by using override keyword. 
        {
           
            Console.WriteLine("hello i am derived class");
            
            
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Testoveriding2 obj1 = new Testoveriding2();
            obj1.Test1();

            Testoveriding1 obj2 = new Testoveriding2();   // calling of methods. 
            obj2.Test1(); 
        }
    }
}
