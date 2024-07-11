using Builder.Interfaces;
using Builder.Planners;

namespace Builder.Builders
{
    public class Opt1RouteBuilder : IBuilder
    {
        private Opt1Route _opt1Route = new Opt1Route();

        public Opt1RouteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._opt1Route = new Opt1Route();
        }

        public void SetModules(string[] order)
        {
            this._opt1Route.Modules = order;
        }

        public void SetNumberOfUsers(int numberOfUsers)
        {
            this._opt1Route.NumberOfUsers = numberOfUsers;
        }
        
        public Opt1Route GetOpt1Route()
        {
            return this._opt1Route;
        }
    }
}
