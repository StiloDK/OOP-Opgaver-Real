using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInspection
{
    public abstract class Vehicle
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }

        public abstract bool InspectionStatus();

        public virtual string DisplyInfo()
        {
            return $"Vehicle: {Brand} {Model}, Production Date: {ProductionDate.ToShortDateString()}";
        }
    }

    public class Car : Vehicle
    {
        public override bool InspectionStatus()
        {
            int yearsSinceProduction = DateTime.Now.Year - ProductionDate.Year;
            int yearsSinceLastInspection = DateTime.Now.Year - LastInspection.Year;

            return yearsSinceProduction > 4 && yearsSinceLastInspection > 2;
        }

        public override string DisplyInfo()
        {
            return $"Car: {Brand} {Model}";
        }
    }

    public class Truck : Vehicle
    {
        public override bool InspectionStatus()
        {
            int yearsSinceProduction = DateTime.Now.Year - ProductionDate.Year;
            int yearsSinceLastInspection = DateTime.Now.Year - LastInspection.Year;

            return yearsSinceProduction > 1 && yearsSinceLastInspection > 1;
        }

        public override string DisplyInfo()
        {
            return $"Yruck: {Brand} {Model}";
        }
    }
}
