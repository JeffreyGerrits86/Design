using Abstract_Factory.Interfaces;
namespace Abstract_Factory.Products
{
    public class CDAB : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into a CDA, but it is not working.");
        }
    }
}
