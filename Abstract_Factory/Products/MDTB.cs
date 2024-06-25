using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Products
{
    public class MDTB : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into an MDT, but it is not working.");
        }
    }
}
