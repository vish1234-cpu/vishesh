using System;

namespace encapsulation  // Encapsulation It is used to bind data members
                         //and member functions into single unit to prevent 
                         //outsiders to access it directly.
{                        
    class User

    {

        private string location;

        private string name;

        public string Location

        {

            get

            {

                return location;

            }

            set

            {

                location = value;

            }

        }

        public string Name

        {

            get

            {

                return name;

            }

            set

            {

                name = value;

            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();   // set accessor will invoke



            u.Name = "Vishesh Kapoor";  // set accessor will invoke



            u.Location = "Delhi";    // get accessor will invoke



            Console.WriteLine("Name: " + u.Name);   // get accessor will invoke



            Console.WriteLine("Location: " + u.Location);

        }
    }
}
