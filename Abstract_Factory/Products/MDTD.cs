using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Products
{
    public class MDTD : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into an MDT with datacommunication.");
        }
    }
}
