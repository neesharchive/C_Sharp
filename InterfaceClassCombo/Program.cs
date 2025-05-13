using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClassCombo
{// -- interface/class combo, multi-level
 // 1. SmartDevice inherits DeviceBase and implements INetworked + IRechargeable.
    public class DeviceBase
    {
        public int DeviceID { get; set; } = 101;
    }
    interface INetworked
    {
        string NetworkName { get; set; }
        void Start();

    }
    interface IRechargeable
    {
        float RechargePrice {  get; set; }
        void Start();
    }
    public class SmartDevices:DeviceBase,INetworked, IRechargeable
    {
        public float RechargePrice { get; set; } = 399.00f;
        public string NetworkName { get; set; } = "AirNet";
        void INetworked.Start()
        {
            Console.WriteLine("Start the network");
        }
        void IRechargeable.Start()
        {
            Console.WriteLine("Recharge the plans");
        }
    }
 // 2. Interface IReadable inherits IPrintable → class implements both.
    interface IPrintable
    {
        void printIT();
    }
    interface IReadable : IPrintable
    {
        void readIT();
    }

    public class Printer : IReadable
    {
        public void printIT()
        {
            Console.WriteLine("Printing it");
        }
        public void readIT()
        {
            Console.WriteLine("Reading it");
        }
    }
 // 3. Parent class and interface both define same method → call using base, derived, interface refs.

    public class A
    {
        public void printIT()
        {
            Console.WriteLine("Printing from A");
        }
    }
    public class B : A, IPrintable
    {
        void IPrintable.printIT()
        {
            Console.WriteLine("Printable form B");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.printIT();

            IPrintable p = b;
            p.printIT();

            SmartDevices smartDevices = new SmartDevices();
            smartDevices.RechargePrice = 450.50f;
            Console.WriteLine(smartDevices.DeviceID);
            Console.WriteLine(smartDevices.NetworkName);
            INetworked networked = smartDevices;
            networked.Start();
            IRechargeable rechargeable = smartDevices;
            rechargeable.Start();


            Console.Read();
        }
    }
}
