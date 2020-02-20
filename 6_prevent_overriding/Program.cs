using System;

namespace prevent_overriding 
{
    class Test1
    {
        public virtual void testme()
        {
            Console.WriteLine("i am a public method"); 
        }
    }

    class Test2:Test1 
    {
        public sealed override void testme()
        {
            Console.WriteLine("this one is sealed method");
        }
    }

    class Test3:Test2
    {
        public override void testme() // this is the error that testme() method is sealed in class Test2(). 
        {
            Console.WriteLine("this method is sealed in class test2"); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test1 t = new Test2();
            t.testme(); 
        }
    }
}
