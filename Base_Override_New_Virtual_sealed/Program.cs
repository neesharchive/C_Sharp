using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Override_New_Virtual_sealed
{// 1. Create Vehicle class with virtual Drive(); Car: override, Truck: new. Print from base ref.
    public class Vehicle
    {
        public virtual void Drive()
        {
            Console.WriteLine("Driving the Vehicle");
        }
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started");
        }
    }
    public class Car : Vehicle
    {
        public sealed override void Start()
        {
            Console.WriteLine("Car started");
        }
        public override void Drive()
        {

            Console.WriteLine("Driving the Car");
        }
    }
    public class Truck : Vehicle
    {

        public new void Drive()
        {
            Console.WriteLine("Driving the Truck");
        }
    }
    // 2. Create sealed override method and show failure to override in next level.
    public class Bike : Car
    {
        //Wont happened, sealed in Car. 
        //public override void Start()
        //{
        //    Console.WriteLine("Bike started");
        //}

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehicle v = new Vehicle();
            v.Drive();
            v = new Car();
            v.Drive();
            v = new Truck();
            v.Drive();

            Truck t = new Truck();
            t.Drive();

            Console.Read();
        }
    }
}
