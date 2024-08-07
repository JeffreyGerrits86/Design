namespace Prototype
{
    public class MDT : Device
    {
        public Device Clone()
        {
            return new MDT();
        }

        public void LogOn()
        {
            Console.WriteLine("The MDT is logged in!");
        }
    }
}
