/*In summary, factories allow for the creation of objects from a factory object method. This allows for the expansion of classes without having to rewrite the main code. 
 * You could theoretically add a class and change an input. In the example I will build a simple program that calls a hardware connection, depending upon the hardware type (BCT/MDT).

 Basic steps of implementing a Factory type design pattern:
- Create an Interface from which your classes can inherit
- Create classes that inherit from the interface above and have them perform a similar function. I will use an EstablishConnection() function
- Create the factory class that can build objects from the interface, depending upon an input parameter
- In Main(), instantiate the Factory and have it build different connections from the same method
- Have the objects perform the functions to check

  Follow-up: Let's say I want to add a new type of hardware: CDA. How much do I need to change?
  Answer: Added CDAConnection class --> added constructor for CDAConnection to Connectionfactory and that was all.
          Not only was this very easy to add, but if this was a client/server type application, where the program class would be the client side and 
          everything else ran on a server, I wouldn't have to update the clients to add this new connection. */

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConnectionFactory connectionFactory = new ConnectionFactory();
            string input;

            do
            {
                Console.WriteLine("Enter a connection type or 'exit' to escape.");
                Console.Write("Your input: ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("No input found, try again");
                    Console.ReadKey();
                    Console.Clear();    
                }
                else
                {
                    IConnection connection = connectionFactory.CreateConnection(input);
                    if (connection != null)
                    {
                        connection.EstablishConnection();
                        Console.ReadKey();
                        Console.Clear();
                    }                    
                }
            } while (input.ToLower() != "exit");
            
        }
    }
}
