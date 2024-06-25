using Abstract_Factory.Interfaces;
namespace Abstract_Factory.Products
{
    public class CDAT : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into a CDA with Taximeter function only.");
        }
    }
}
