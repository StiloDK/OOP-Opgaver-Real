using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraktionmed_arv
{
    public interface Wheels
    {
        int MaxSize { get; set; }
        void SetTireType(bool isWinterTire);
        string Info();
    }

    public abstract class Vehicle : Wheels
    {
        public int MaxSize { get; set; }

        public abstract void SetTireType(bool isWinterTire);

        public string Info() => "Brug mig for alle objekter som køres på hjul.";

        public string GetVehicleInfo()
        {
            return $"{this}\n{Info()}";
        }
    }

    public class Car : Vehicle
    {
        public override void SetTireType(bool isWinterTire)
        {
            MaxSize = isWinterTire ? 16 : 22;
        }

        public override string ToString()
        {
            return "Car:\nMax rim size: " + MaxSize;
        }
    }

    public class Truck : Vehicle
    {
        public override void SetTireType(bool isWinterTire)
        {
            MaxSize = isWinterTire ? 17 : 20;
        }

        public override string ToString()
        {
            return "Truck:\nMax rim size: " + MaxSize;
        }
    }

}
