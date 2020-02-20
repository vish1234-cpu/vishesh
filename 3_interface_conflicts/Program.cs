using System;

namespace interface_conflicts
{
    public interface I1 // first interface 
    {
        void msg()
        {

        }
    }

    public interface I2 // second interface 
    {
        void msg()
        {

        }
    }

    class Conflict: I1,I2  // class inheriting i1 and i2 ... this is multiple inheritance possible by interfaces only. 
    {
        public void msg()
        {
            Console.WriteLine("i am m1 "); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conflict con = new Conflict();
            con.msg();     // no error the message will print "i am m1"
        }
    }
}
