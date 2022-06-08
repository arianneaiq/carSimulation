using System;
using System.Collections.Generic;
using System.Text;

namespace carSimulation
{
    public class Car
    {
        private  string Brand;
        private  int CurrentSpeed;
        private int MaximumSpeed;


        public void SetBrand ( String aBrand)
        {
           Brand = aBrand;
        }  
        
        public void SetMaxSpeed(int maxSpeed)
        {
            MaximumSpeed = maxSpeed;
        }

        public void SetCurrentSpeed (int aCurrentSpeed)
        {
            CurrentSpeed = aCurrentSpeed;
        }

        public String AsAString()
        {
            return $"Speed of my {Brand} is {CurrentSpeed} km/h and its maximum speed is {MaximumSpeed} km/h.";
        }

        public String AsAString1()
        {
            return "max";
        }

        public void SpeedUp()
        {

            CurrentSpeed += 7;
            /*  if (CurrentSpeed > 0)
              {
                  CurrentSpeed += 7;
              } 
              else if (CurrentSpeed == MaximumSpeed)
              {
                  CurrentSpeed = MaximumSpeed;
              }
              else
              {
                  CurrentSpeed = 0;
              }
             */

        }

        public void SlowDown()
        {
            CurrentSpeed -= 10;
            /*
            if (CurrentSpeed > 11 && CurrentSpeed <= MaximumSpeed)
            {
                CurrentSpeed -= 10;
            }
            else
            {
                CurrentSpeed = 0;
            }
            */


        }

        
       
    }
}
