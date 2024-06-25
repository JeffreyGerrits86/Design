using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Factories
{
    static class AbstractFactory
    {
        public static IDeviceFactory BuildFactory(string serviceType)
        {
            switch (serviceType.ToLower())
            {
                case "brick":
                    return new Brickfactory();
                case "datacommunication":
                    return new DatacommunicationFactory();
                case "taximeter":
                    return new TaximeterFactory();
                default:
                    Console.WriteLine("No such device found.");
                    Console.Clear();
                    return null;
            }
        }
    }
}
