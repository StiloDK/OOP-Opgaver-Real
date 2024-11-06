using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace VehicleInspection
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car
            {
                Brand = "Audi",
                Model = "A4",
                ProductionDate = new DateTime(2018, 7, 1),
                LastInspection = new DateTime(2022, 12, 8)
            };

            Truck truck = new Truck
            {
                Brand = "Volvo",
                Model = "FH",
                ProductionDate = new DateTime(2018, 10, 1),
                LastInspection = new DateTime(2021, 10, 1)
            };

            Console.WriteLine(car.DisplyInfo() + (car.InspectionStatus() ? " - Requires Inspection" : " - No Inspection Needed"));
            Console.WriteLine(truck.DisplyInfo() + (truck.InspectionStatus() ? " - Requires Inspection" : " - No Inspection Needed"));
        }
    }
}
