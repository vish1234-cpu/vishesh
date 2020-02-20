using System;

namespace diff_abstract_interface
{
    public abstract class Abstract              /* An abstract class is a way to achieve the abstraction in
                                                C#. An Abstract class is never intended to be instantiated 
                                                directly. This class must contain at least one abstract method,
                                                which is marked by the keyword or modifier abstract in the class definition.
                                                The Abstract classes are typically used to define a base class. */  
    {
        public abstract void absmethod();
       
    }

    public interface i1                          /* Interface in C# is a blueprint of a class.
                                                  It is like abstract class because all the methods
                                                  which are declared inside the interface are abstract methods.
                                                  It cannot have method body and cannot be instantiated.
                                                  It is used to achieve multiple inheritance which can't be achieved by class. */ 
    {
        void m1()
        {

        }
    }

    class Diff:Abstract,i1
    {
        public void m1()
        {
            Console.WriteLine("i am interface m1");
        }

        public override void absmethod()
        {
            Console.WriteLine("hello i am abstract method m1");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Diff d = new Diff();
            d.absmethod();
            d.m1(); 
        }
    }
}
