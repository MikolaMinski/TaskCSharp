using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Vehicle
{
    internal class Lorry : Car
    {
        private double cargoWeight;
        public double CargoWeight
        {
            get { return cargoWeight; }
            set
            {
                if (value > 5000)
                    throw new Exception("Масса груза не может превышать 5000 кг");
                if (value < 0)
                    throw new Exception("Масса груза не может быть отрицательным");
                cargoWeight = value;
            }
        }
        public Lorry(double cargoWeight, double fuelConsumption, double fuelTankVolume, double currentFuelAmount) : base("Грузовой автомобиль", fuelConsumption, fuelTankVolume, currentFuelAmount)
        {
            CargoWeight = cargoWeight;
        }
        public override string GetPowerReserveInfo()
        {
            return $"Запас хода грузового автомобиля {GetDistanceByCurrentFuelAmount() - (GetDistanceByCurrentFuelAmount() / 100 * (0.02 * CargoWeight))} км, с учётом {CargoWeight} кг груза";
        }
    }
}
