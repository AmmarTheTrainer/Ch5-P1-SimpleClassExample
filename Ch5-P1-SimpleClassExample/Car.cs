using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P1_SimpleClassExample
{
    class Car
    {
        // The 'state' of the Car.
        public string petName;
        public int currSpeed;


        //// A custom default constructor.
        //public Car()
        //{
        //    //Console.WriteLine("default constructor overwrite , Invoked !");
        //     petName = "Suzuki FX";
        //     currSpeed = 10;
        //}

        public Car() => Console.WriteLine("default ctor"); 

        #region Custom Constructors

        //// Here, currSpeed will receive the
        //// default value of an int (zero).
        //public Car(string pn)
        //{
        //    petName = pn;
        //}
        public Car(string pn) => petName = pn;

        // Let caller set the full state of the Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }
        
        #endregion

        // The functionality of the Car.
        // Using the expression-bodied member syntax introduced in C# 6
        public void PrintState() => Console.WriteLine("{0} is going {1} KM/H.", petName, currSpeed);
        public void SpeedUp(int delta) => currSpeed += delta;

    }
}
