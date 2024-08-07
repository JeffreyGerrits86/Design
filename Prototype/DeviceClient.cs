namespace Prototype
{
    public class DeviceClient
    {
        private Device _devicePrototype;

        public DeviceClient(Device devicePrototype)
        {
            _devicePrototype = devicePrototype;
        }

        public Device createDevice()
        {
            return _devicePrototype.Clone();
        }
    }
}
