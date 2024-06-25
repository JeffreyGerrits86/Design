using Abstract_Factory.Interfaces;
namespace Abstract_Factory.Products
{
    public class BCTD : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into a BCT with datacommunication.");
        }
    }
}
