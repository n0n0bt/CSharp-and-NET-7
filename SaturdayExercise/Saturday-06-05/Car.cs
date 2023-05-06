using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_06_05
{
    public class Car : Vehicle
    {
        private const double ACConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        // constructor


        public override void Drive(double distance)
        {
            double fuelNeeded = distance * (base.FuelConsumption + ACConsumption);

            if (fuelNeeded <= base.FuelQuantity)
            {
                base.FuelQuantity -= fuelNeeded;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public override double Refuel(double fuelAmount)
        {
            return base.FuelQuantity += fuelAmount;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
