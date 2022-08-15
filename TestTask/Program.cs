using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Vehicle;

namespace TestTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> vehicles = new List<Car>();
            vehicles.Add(new PassengerCar(3, 9, 50, 50));
            vehicles.Add(new Lorry(200, 10, 50, 50));

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.VehicleType);
                Console.WriteLine(vehicle.GetPowerReserveInfo());
            }

            Console.ReadKey();
        }
    }
}
