using Abstract_Factory.Interfaces;
namespace Abstract_Factory.Products
{
    public class CDAD : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into a CDA with datacommunication.");
        }
    }
}
