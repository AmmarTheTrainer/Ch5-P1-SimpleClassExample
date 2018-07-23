using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P1_SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Lecture 4 - Project 1 - OOP with C# \n");

            //// Allocate and configure a Car object.
            //Car myCar = new Car();

            ////myCar.petName = "Khadim";
            ////myCar.currSpeed = 10;

            //myCar.PrintState();

            //// Make a Car called Mary going 0 MPH.
            //Car mary = new Car("Honda City");
            //mary.PrintState();
            //// Make a Car called Daisy going 75 MPH.
            //Car daisy = new Car("Civic", 170);
            //daisy.PrintState();

            ////// Speed up the car a few times and print out the new state.

            ////for (int i = 0; i <= 10; i++)
            ////{
            ////    myCar.SpeedUp(5);
            ////    myCar.PrintState();
            ////}

            #region The Default Constructor Revisited

            //Motorcycle mc = new Motorcycle(3);
            //mc.PopAWheely();

            #endregion

            #region The Role of the this Keyword

            // Make a Motorcycle with a rider named Tiny?
            Motorcycle c = new Motorcycle(5);
            c.SetDriverName("Machi");
            c.PopAWheely();
            Console.WriteLine("Rider name is {0}", c.driverName); // Prints an empty name value!

            #endregion

            Console.ReadLine();
        }
    }
}
