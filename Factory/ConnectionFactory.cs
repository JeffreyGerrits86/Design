using Factory.Connections;

namespace Factory
{
    public class ConnectionFactory
    {
        public IConnection GetConnection(string connectionName)
        {
            switch (connectionName.ToLower())
            {
                case "bct":
                    return new BCTConnection();
                case "mdt":
                    return new MDTConnection();
                case "cda":
                    return new CDAConnection();
                case "exit":
                    return null;
                default:
                    Console.WriteLine("That is not a valid connection type, try again.");
                    Console.ReadKey();
                    Console.Clear();
                    return null;           
            }
        }
    }
}
