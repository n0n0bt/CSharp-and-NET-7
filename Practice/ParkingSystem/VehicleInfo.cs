using ParkingSystem.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    public class VehicleInfo
    {
        public Vehicle Vehicle { get; set; }
        public int TimeParking { get; set; }
        public bool IsCar { get; set; }
        public bool IsBus { get; set; }
        public bool IsLorry { get; set; }
        public VehicleInfo() { }
        public VehicleInfo(Vehicle vehicle, int timeParking, bool isCar, bool isBus, bool isLorry)
        {
            Vehicle = vehicle;
            TimeParking = timeParking;
            IsCar = isCar;
            IsBus = isBus;
            IsLorry = isLorry;
        }


    }
}
