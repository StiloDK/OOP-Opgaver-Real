using System.Diagnostics;

namespace Abstraktionmed_arv
{
    internal class Program
    {
        static void Main()
        {
            Vehicle car = new Car();
            car.SetTireType(false);
            Console.WriteLine(car.GetVehicleInfo());

            Vehicle truck = new Truck();
            truck.SetTireType(true);
            Console.WriteLine(truck.GetVehicleInfo());
        }
    }
}
