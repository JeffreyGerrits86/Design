using Abstract_Factory.Interfaces;

namespace Abstract_Factory.Products
{
    public class BCTB : IDevice
    {
        public void Login()
        {
            Console.WriteLine("You tried to login to this BCT but this thing is broken.");
        }
    }
}
