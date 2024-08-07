namespace Prototype
{
    /*The prototype design pattern is useful for copying complex objects without having to iterate through every property,
     specifically when the objects are similar.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //You set up a prototype to act as a blueprint from which to clone. Perhaps using a Builder pattern with a Director could come in handy here,
            //since you'll mostly use this for complex objects. In this case it is obviously a simple object.
            Device mdtPrototype = new MDT();
            //Here we instantiate a client that takes the prototype as an argument. You can use this to start pumping MDTs
            DeviceClient client = new DeviceClient(mdtPrototype);

            //Start pumping!
            Device mdt = client.createDevice();
            Device md2 = client.createDevice();
            mdt.LogOn();
            md2.LogOn();
        }
    }
}
