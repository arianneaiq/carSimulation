using System;
using System.Collections.Generic;
using System.Text;

namespace carSimulation
{
    public class Car
    {
        public string Brand;
        public int CurrentSpeed;
        public int MaximumSpeed;

       
       /*( public Car(string brand, int currentSpeed, int maximumSpeed)        {

            Brand = brand;
            CurrentSpeed = currentSpeed;
            MaximumSpeed = maximumSpeed;
        }*/

        public void SetBrand ( String brand)
        {
            this.Brand = brand;
        }

        public String AsAString()
        {
            return this.Brand;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.MaximumSpeed = maxSpeed;
        }

            public void SpeedUp()
            {
                CurrentSpeed += 7;
            }

            public void SlowDown()
            {
                CurrentSpeed -= 10;
            }
       
    }
}
