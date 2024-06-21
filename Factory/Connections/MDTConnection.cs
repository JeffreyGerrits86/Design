namespace Factory.Connections
{
    internal class MDTConnection : IConnection
    {
        public void EstablishConnection()
        {
            Console.WriteLine("MDT connection established.\n");
        }
    }
}
