using System;
using System.Collections.Generic;
using System.Text;

namespace instanceandstatic
{
    class Class1
    {

        int a;
        static int b;

        public void newmethod()
        {
            a++;
            b++;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
