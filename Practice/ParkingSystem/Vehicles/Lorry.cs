using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehicles
{
    public class Lorry : Vehicle
    {
        public int Capacity { get; set; }

        public Lorry() { }

        public Lorry(int capacity, string model, int productionYear, Person owner, int weight, int width, string fuelType, int passengerNum) : base(model, productionYear, owner, weight, width, fuelType, passengerNum)
        {
            Capacity = capacity;
        }

        public override int IsEconomic()
        {
            return base.IsEconomic();
        }
    }
}
