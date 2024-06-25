namespace Abstract_Factory.Interfaces
{
    public interface IDeviceFactory
    {
        IDevice CreateDevice(string deviceType);
    }
}
