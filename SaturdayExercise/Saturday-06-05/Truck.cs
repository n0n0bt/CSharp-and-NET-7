using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saturday_06_05
{
    public class Truck : Vehicle
    {
        private const double ACConsumption = 1.6;
        private const double UsedFuel = 95;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double distance)
        {
            double fuelNeeded = distance * (base.FuelConsumption + ACConsumption);

            if (fuelNeeded <= base.FuelQuantity)
            {
                base.FuelQuantity -= fuelNeeded;
                Console.WriteLine($"Truck travelded {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }

        public override double Refuel(double fuelAmount)
        {
            return base.FuelQuantity += fuelAmount * 0.95;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
