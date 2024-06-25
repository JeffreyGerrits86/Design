/*
 The point to an abstract factory is the same as the regular factory, but in this case we need to have variations of variations. 
 Let's say we have three types of devices: BCT, MDT and CDA. These devices all have three variations in themselves: Taximeter, Datacommunication and Brick. 

                    BCT         MDT         CDA

Taximeter           BCTT        MDTT        CDAT
Datacommunication   BCTD        MDTD        CDAD
Brick               BCTB        MDTB        CDAB

 Just as with the original factory, we need to build a somewhat complex system to ensure that we can update our products without having to update the clients.

 Steps to implement:
 - Build product interface and subclasses that inherit from it. So BCTT : IBCT in this example. 
 - Build abstract factory an interface with a list of creation methods for all products that are part of the product family. So IDeviceFactory that can create BCT's, MDT's and CDA's. 
 - Build Factories that inherit from the IDeviceFactory. So TaximeterDeviceFactory that can create BCTT, MDTT and CDAT.
 - Test functionality with inputs
 */

using Abstract_Factory.Factories;
using Abstract_Factory.Interfaces;

namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deviceInput;
            string functionInput;

            do
            {
                Console.WriteLine("Enter a function to have or 'exit' to escape. You can choose from: \n- Datacommunication\n- Taximeter\n- Brick");
                Console.Write("Your input: ");
                functionInput = Console.ReadLine();

                if (string.IsNullOrEmpty(functionInput))
                {
                    Console.WriteLine("No function input found, try again");
                    Console.ReadKey();
                    Console.Clear();
                }else if (functionInput.ToLower() == "exit")
                {
                    break;
                }
                else
                {
                    IDeviceFactory deviceFactory = AbstractFactory.BuildFactory(functionInput);

                    if (deviceFactory == null)
                    {
                        Console.WriteLine("No such function found, try again");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }                       

                    Console.WriteLine("Enter your device to login to. You can choose from:\n- BCT\n- MDT\n- CDA");
                    Console.Write("Your input: ");
                    deviceInput = Console.ReadLine();

                    if (string.IsNullOrEmpty(deviceInput))
                    {
                        Console.WriteLine("No device input found, try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        IDevice device = deviceFactory.CreateDevice(deviceInput);

                        if (device == null)
                            continue;

                        device.Login();
                        Console.ReadKey();
                        Console.Clear();
                    }                    
                }
            } while (functionInput.ToLower() != "exit");
        }
    }
}
