using Abstract_Factory.Interfaces;
using Abstract_Factory.Products;
namespace Abstract_Factory.Factories
{
    public class DatacommunicationFactory : IDeviceFactory
    {
        public IDevice CreateDevice(string deviceType)
        {
            switch (deviceType.ToLower())
            {
                case "bct":
                    return new BCTD();
                case "mdt":
                    return new MDTD();
                case "cda":
                    return new CDAD();
                default:
                    Console.WriteLine("Device unknown.");
                    Console.ReadKey();
                    Console.Clear();
                    return null;
            }
        }
    }
}
