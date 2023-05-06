﻿using ParkingSystem.Vehicles;

namespace ParkingSystem
{
    public class Parking
    {
        public int ParkingId { get; set; }
        public int ParkingSpaceNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PricePerHour { get; set; }
        public int Discount { get; set; }
        public int FreeDays { get; set; }

        public Company OwnerCompany { get; set; }

        public List<VehicleInfo> VehicleInfos { get; set; } = new List<VehicleInfo>();

        public Parking() { }

        public Parking(int parkingId, int parkingSpaceNumber, string address, string city,
            int pricePerHour, int discount, int freeDays, Company ownerCompany)
        {
            ParkingId = parkingId;
            ParkingSpaceNumber = parkingSpaceNumber;
            Address = address;
            City = city;
            PricePerHour = pricePerHour;
            Discount = discount;
            FreeDays = freeDays;
            OwnerCompany = ownerCompany;
        }

        public string addVehicle(Vehicle vehicle, int TimeOfParking)
        {
            if (vehicle != null)
            {
                if (vehicle is Car)
                {
                    VehicleInfo info = new VehicleInfo(vehicle, TimeOfParking, true, false, false);
                    VehicleInfos.Add(info);
                }
                else if (vehicle is Lorry)
                {
                    VehicleInfos.Add(new VehicleInfo(vehicle, TimeOfParking, false, false, true));
                }
                else
                {
                    VehicleInfos.Add(new VehicleInfo(vehicle, TimeOfParking, false, true, false));
                }
                return "added vehicle";
            }
            else
            {
                return "not added vehicle";
            }
        }

        public void removeVehicle(string IdVehicle)
        {
            foreach (VehicleInfo vehicle in VehicleInfos)
            {
                if (vehicle.Vehicle.Model.Equals(IdVehicle))
                {
                    VehicleInfos.Remove(vehicle);
                }
            }
        }
    }
}