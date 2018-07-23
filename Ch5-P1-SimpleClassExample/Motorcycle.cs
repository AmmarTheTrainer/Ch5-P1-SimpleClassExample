using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch5_P1_SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        // New members to represent the name of the driver 
        //public string name;
        public string driverName;


        
        // Put back the default constructor, which will set all data members to default values.
        public Motorcycle() { }
        // Our custom constructor.
        //public Motorcycle(int intensity)
        //{
        //    driverIntensity = intensity;
        //}

        // Redundant constructor logic!
        public Motorcycle(int intensity) : this(intensity, "")
        {
            SetIntensity(intensity);
            //if (intensity > 10)
            //{
            //    intensity = 10;
            //}
            //driverIntensity = intensity;
        }
        public Motorcycle(string name) : this(0, name)
        {
            //if (intensity > 10)
            //{
            //    intensity = 10;
            //}
            //driverIntensity = intensity;
        }
        public Motorcycle(int intensity, string name)
        {
            SetIntensity(intensity);
            //if (intensity > 10)
            //{
            //    intensity = 10;
            //}
            //driverIntensity = intensity;
            driverName = name;
        }

        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
        }

        //public void SetDriverName(string name)
        //{
        //    this.name = name;
        //}
        public void SetDriverName(string name)
        {
            this.driverName = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaaeewww!");
            }
        }

    }
}
