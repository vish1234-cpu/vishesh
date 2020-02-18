using System;

namespace accessspecifiers
{

    class Privatetest
    {
        private void test1()
        {
            Console.WriteLine("hello i am private method");
        }
    }
    class Publictest
    {
        public void test2()
        {
            Console.WriteLine("hello i am public method");
        }
    }

    class Protectedtest 
    {
        protected void test3()
        {
            Console.WriteLine("hello i am protected");
        }
    }


    class Protectedinternaltest
    {
        protected internal void test4()
        {
            Console.WriteLine("hello i am protected internal");
        }
    }


    class Internaltest
    {
        internal void test5()
        {
            Console.WriteLine("hello i am internal");
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            /*
            Privatetest obj1 = new Privatetest();
            obj1.test1(); */  

            Publictest obj2 = new Publictest();
            obj2.test2();

            /*
            Protectedtest obj3 = new Protectedtest();
            obj3.test3(); */

            Protectedinternaltest obj4 = new Protectedinternaltest();
            obj4.test4();

            Internaltest obj5 = new Internaltest();
            obj5.test5();

            Console.ReadLine();


        }
    }
}
