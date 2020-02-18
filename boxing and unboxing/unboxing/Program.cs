using System;

namespace unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            object iobj = i;
            iobj = 200; 

            int j = (int)iobj;

            Console.WriteLine(j);
            Console.WriteLine(iobj);
            Console.WriteLine(i);
        }
    }
}
