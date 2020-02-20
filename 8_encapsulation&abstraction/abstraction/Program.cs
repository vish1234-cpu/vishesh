using System;

namespace abstractionexample // Abstraction is used to hide unwanted data and show only required properties and methods.

{
    public class Laptop

    {

        private string brand;

        private string model;

        public string Brand

        {

            get { return brand; } // using get and set properties to access private members
                                  // of class same as we have done in abstraction.
            set { brand = value; }

        }

        public string Model

        {

            get { return model; }

            set { model = value; }

        }

        public void Laptopdetails() // public method which will be called in main class and is only meant to be shown. 

        {

            Console.WriteLine("Brand: " + Brand);

            Console.WriteLine("Model: " + Model);

        }

        private void Laptopkeyboard() // private method which is not called in main method. 

        {

            Console.WriteLine("Type using Keyword");

        }

        private void MotherboardInfo() // private method which is not called in main method

        {

            Console.WriteLine("MotheBoard Information");

        }

        private void Internalprocessor() // private method which is not called in main method. 

        {

            Console.WriteLine("Processor Information");  

        }

    }

    class Program
    {
        static void Main(string[] args)  // In this program we are only showing brand and modals as basic laptop details.
        {
            Laptop lap  = new Laptop();  // while other methods like internalprocesser, motherboard, keyboard are private which 

            lap.Brand = "Dell";          // we dont want to show. 

            lap.Model = "Dell A";

            lap.Laptopdetails(); 

   
        }
    }
}
