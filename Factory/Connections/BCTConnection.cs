namespace Factory.Connections
{
    internal class BCTConnection : IConnection
    {
        public void EstablishConnection()
        {
            Console.WriteLine("BCT connection established");
        }
    }
}
