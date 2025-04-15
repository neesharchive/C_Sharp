using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDeviceInterface
{
    // 1. Define an interface IDevice with:
    //    - Method: void PowerOn()
    //    - Property: bool IsOn { get; }
    interface IDevice
    {
        bool IsOn {  get; }
        void PowerOn();
    }
    // 2. Define an interface IAudioDevice that inherits IDevice and adds:
    //    - Method: void PlaySound(string sound)
    interface IAudioDevice : IDevice
    {
        void PlaySound(string sound);
    }
    // 3. Define an interface IMobileDevice with:
    //    - Method: void Call(string number)
    interface IMobileDevice
    {
        void Call(string number);
    }
    // 4. Define a third interface IAdvancedDevice that inherits both IAudioDevice and IMobileDevice
    interface IAdvancedDevice:IAudioDevice, IMobileDevice
    {

    }
    // 5. Create an abstract class SmartDevice with:
    //    - Virtual method: void Describe() { Console.WriteLine("I am a smart device."); }
    public abstract class SmartDevice
    {
        public virtual void Describe()
        {
            Console.WriteLine("I am a smart device");
        }
    }
    // 6. Create a class Phone that:
    //    - Inherits SmartDevice
    //    - Implements IAdvancedDevice
    //    - Explicitly implements IDevice.PowerOn()
    //    - Publicly implements PlaySound(string) and Call(string)
    //    - Implements the IsOn property (backed by a private field)
    //    - Does not override Describe()
    public class Phone:SmartDevice,IAdvancedDevice
    {
        bool _ison;
        public bool IsOn
        {
            get { return _ison; }
            set
            {
                _ison = value;
            }
        }
        void IDevice.PowerOn()
        {
            Console.WriteLine("Power is On");
        }
        public void PlaySound(String sound)
        {

        }
        public void Call(string  sound)
        {

        }
        public void Describle()
        {

        }
    }
    // 7. Create a class Speaker that:
    //    - Inherits SmartDevice
    //    - Implements only IAudioDevice
    //    - Implements PowerOn() publicly (not explicit)
    //    - Implements PlaySound(string)
    //    - Implements IsOn
    //    - Uses `new` to hide Describe() and print: "I am a speaker."
    public class Speaker:SmartDevice,IAudioDevice
    {
        public void PowerOn()
        {

        }
        public void PlaySound(String sound)
        {

        }
        public bool IsOn { get; }
        public new void Describe()
        {
            Console.WriteLine("I am a speaker");
        }

    }
    // 10. BONUS:
    //    - Create two interfaces IAlpha and IBeta, both declaring: void Show()
    //    - Create class Gadget that implements both
    //    - Use explicit interface implementation to resolve Show()
    //    - Call Show() for each via its respective interface reference
    internal class Program
    {
        static void Main(string[] args)
//In Main:
//Create one Phone and one Speaker object
//Call PowerOn() via IDevice reference for Phone, and directly for Speaker
//Call Describe() via base class reference and object reference for both Phone and Speaker
//Attempt to override an interface method in Phone using `override` or `sealed`
//and explain (in comment) why it fails

        {
            Phone phone = new Phone();
            Speaker speaker = new Speaker();
            ((IDevice)phone).PowerOn();
            speaker.PowerOn();

            SmartDevice device = new Phone();
            device.Describe();
            device = new Speaker();
            device.Describe();
            
            Console.Read();
        }
    }
}
