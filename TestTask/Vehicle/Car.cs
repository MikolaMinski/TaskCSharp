using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Vehicle
{
    abstract class Car
    {
        public string VehicleType { get; private set; }

        public double FuelConsumption { get; private set; }

        public double FuelTankVolume { get; private set; }

        public double CurrentFuelAmount { get; set; }

        public double Speed { get; set; }

        protected Car(string vehicleType, double fuelConsumption, double fuelTankVolume, double currentFuelAmount)
        {
            VehicleType = vehicleType;
            FuelConsumption = fuelConsumption;
            FuelTankVolume = fuelTankVolume;
            CurrentFuelAmount = currentFuelAmount;
        }


        public double GetDistanceByFuelTankVolume()
        {
            return FuelTankVolume / FuelConsumption * 100;
        }

        public double GetDistanceByCurrentFuelAmount()
        {
            return CurrentFuelAmount / FuelConsumption * 100;
        }

        public double CalculateFuelConsumption(double fuelAmount, double distance)
        {
            return fuelAmount / distance * 100;
        }

        public abstract string GetPowerReserveInfo();
    }
}
