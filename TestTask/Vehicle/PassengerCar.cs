using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Vehicle
{
    internal class PassengerCar : Car
    {
        private int passengerCount;

        public int PassengerCount
        {
            get { return passengerCount; }
            set
            {
                if (value > 4)
                    throw new Exception("Количество пассажиров не может превышать 4 человека");
                if (value < 0)
                    throw new Exception("Количество пассажиров не может быть отрицательным");
                passengerCount = value;
            }
        }

        public PassengerCar(int passengerCount, double fuelConsumption, double fuelTankVolume, double currentFuelAmount) : base("Легковой автомобиль", fuelConsumption, fuelTankVolume, currentFuelAmount)
        {
            PassengerCount = passengerCount;
        }


        public override string GetPowerReserveInfo()
        {
            return $"Запас хода легкового автомобиля {GetDistanceByCurrentFuelAmount() - (GetDistanceByCurrentFuelAmount() / 100 * (6 * PassengerCount))} км, с учётом {PassengerCount} пассажира(ов)";
        }
    }
}
