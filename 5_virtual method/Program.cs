using System;

namespace virtual_method
{
    class Virtual_method

    {
        public virtual void show() // this is a virtual method. virtual methods are always created in the base class. 
        {
            Console.WriteLine("hello i am virtual method");
        }

    }

    class Overriden_method:Virtual_method
    {
        public override void show() // the virtual method is override in the derived class. 
        {
            Console.WriteLine("hello i am override method"); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Overriden_method obj1 = new Overriden_method();
            obj1.show();

            Virtual_method obj2 = new Overriden_method();
            obj2.show(); 

        }
    }
}
