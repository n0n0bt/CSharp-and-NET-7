using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_06_05
{
    public abstract class Vehicle
    {
        // fields, private modifier
        private double fuelQuantity;
        private double fuelConsumption;

        // constructor
        protected Vehicle(double fuelQuantity, double fuelConsumption) 
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }


        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { this.fuelConsumption = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        // methods
        public abstract void Drive(double distance);


        public abstract double Refuel(double fuelAmount);


        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
        }

    }
}
