using System;

namespace multiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("This Program will print the tables of numbers between 1 to 5\n");
            Console.WriteLine("Enter any number between 1 to 5:\n");
            n = Convert.ToInt32(Console.ReadLine());
           
            switch (n)
            {
                case 1:
                   
                        for (i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("{0}*{1}={2}\n", n, i, n * i);
                        }
                    break;

                   

                case 2:
                    for (i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0}*{1}={2}\n", n, i, n * i);
                    }
                    break;

                case 3:
                    for (i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0}*{1}={2}\n", n, i, n * i);
                    }
                    break;

                case 4:
                    for (i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0}*{1}={2}\n", n, i, n * i);
                    }
                    break;

                case 5:
                    for (i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("{0}*{1}={2}\n", n, i, n * i);
                    }
                    break;

                default:
                    if(n>5)
                    {
                        Console.WriteLine("Not Acceptable"); 
                    }
                    break; 



            }
        }
    }
}
