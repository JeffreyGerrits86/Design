using Abstract_Factory.Interfaces;
using Abstract_Factory.Products;

namespace Abstract_Factory.Factories
{
    public class Brickfactory : IDeviceFactory
    {
        public IDevice CreateDevice(string deviceType)
        {
            switch (deviceType.ToLower())
            {
                case "bct":
                    return new BCTB();
                case "mdt":
                    return new MDTB();
                case "cda":
                    return new CDAB();
                default:
                    Console.WriteLine("Device unknown.");
                    Console.ReadKey();
                    Console.Clear();
                    return null;
            }
        }
    }
}
