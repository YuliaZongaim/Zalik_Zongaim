using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    class Car
    {
        private double speed;
        private string color;
        private Owner owner;

        public double getSpeed() 
        {
            return speed;
        }

        public string getColor()
        {
            return color;
        }

        public Owner getOwner() 
        {
            return owner;
        }


        public Car(double speed, string color, Owner owner) 
        {
            this.speed = speed;
            this.color = color;
            this.owner = owner;
        }

        public override string ToString()
        {
            return "Car speed: " + speed + " color: " + color + " owner: " + owner.ToString();
        }
        
    }



}
