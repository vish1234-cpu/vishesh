using System;

namespace convow_if_else_
{
    class Program 
    {
        static void Main(string[] args)
        {
            char ch; 
            Console.Write("Enter an alphabet: ");
            ch = Char.Parse(Console.ReadLine());

            if ((ch >= 'A' && ch <= 'Z') || ch >= 'a' && ch <= 'z')
            {
                if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i'
                    || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                {
                    Console.WriteLine(ch + " is a vowel");
                }
                else
                {
                    Console.WriteLine(ch + " is a consonant");
                }
            }
            else
            {
                Console.WriteLine(ch + " is not an alphabet");
            }



        }
    }
}
