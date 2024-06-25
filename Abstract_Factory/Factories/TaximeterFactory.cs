using Abstract_Factory.Interfaces;
using Abstract_Factory.Products;
namespace Abstract_Factory.Factories
{
    public class TaximeterFactory : IDeviceFactory
    {
        public IDevice CreateDevice(string deviceType)
        {
            switch(deviceType.ToLower())
            {
                case "bct":
                    return new BCTT();
                case "mdt":
                    return new MDTT();
                case "cda":
                    return new CDAT();
                default:
                    Console.WriteLine("Device unknown.");
                    Console.ReadKey();
                    Console.Clear();
                    return null;
            }
        }

    }
}
