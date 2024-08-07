/*Builders allow to create complex objects without having to deal with complex constructors. 
  It works by having a class dedicated to constructing your object. You can even have directors that standardize building projects*/

using Builder.Planners;
using Builder.Director;
using Builder.Builders;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Builder.Director.Director();
            var builder = new CentraleBuilder();
            director.Builder = builder;

            director.BuildFullSuite();
            string[] moduleList = builder.GetModules();

            foreach(string s in moduleList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
