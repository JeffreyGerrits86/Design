namespace Factory.Connections
{
    public class CDAConnection : IConnection
    {
        public void EstablishConnection()
        {
            Console.WriteLine("CDA connection established");
        }
    }
}
