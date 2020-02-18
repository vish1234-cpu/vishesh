using System;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 200;
            object iobj = i;
            i = 900;
            Console.WriteLine(i);
            Console.WriteLine(iobj);
        }
    }
}
