using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Products
{
    public class MDTT : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into an MDT with Taximeter function only.");
        }
    }
}
