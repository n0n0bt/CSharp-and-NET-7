using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehicles
{
    public class Buss : Vehicle
    {
        public bool Toalet { get; set; }

        public Buss() : base() { }

        public Buss(bool toalet, string model, int productionYear, Person owner, int weight, int width, string fuelType, int passengerNum) : base(model, productionYear, owner, weight, width, fuelType, passengerNum)
        {
            Toalet = toalet;
        }

        public override int IsEconomic()
        {
            return base.IsEconomic();
        }
    }
}
