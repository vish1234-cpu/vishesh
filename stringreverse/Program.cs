using System;

namespace stringreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = 0;
            string ch=" " ;
            string reversestring = "";
            Console.WriteLine("Enter Your Name:\n");
            ch = Console.ReadLine();
            Console.WriteLine("your name is:"+ ch);

            foreach(char i in ch)
            {
                len++;
            }

            Console.WriteLine("length:{0}", (len));

            len = len - 1;


            while (len >= 0)
            {
                reversestring = reversestring + ch[len];
                len--;
            }
            Console.WriteLine(reversestring);

            Console.ReadLine();





        }
    }
}
