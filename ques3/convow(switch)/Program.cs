using System;

namespace convow_switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character:");

            /* another method to take string input
             */

            char ch = Convert.ToChar(Console.ReadLine()); 
            int i = ch;

            if( i>=48 && i<=57)
            {
                Console.WriteLine("you have entered a number");
            }

            else 
            {
                switch(ch)
                {
                    case 'a':
                    case 'A':
                        Console.WriteLine("vowel");
                        break;


                    case 'e':
                    case 'E':
                        Console.WriteLine("vowel");
                        break;

                    case 'i':
                    case 'I':
                        Console.WriteLine("vowel");
                        break;

                    case 'o':
                    case 'O':
                        Console.WriteLine("vowel");
                        break;

                    case 'u':
                    case 'U':
                        Console.WriteLine("vowel");
                        break;

                    default:
                        Console.WriteLine("Consonant");
                        break;



                }
            }
        }
    }
}
