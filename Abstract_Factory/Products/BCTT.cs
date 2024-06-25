using Abstract_Factory.Interfaces;
namespace Abstract_Factory.Products
{
    public class BCTT : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You have logged into a BCT with taximeter only.");
        }
    }
}
