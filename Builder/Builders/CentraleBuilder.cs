using Builder.Interfaces;
using Builder.Planners;

namespace Builder.Builders
{
    public class CentraleBuilder : IBuilder
    {
        private Centrale _centrale = new Centrale();

        public CentraleBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._centrale = new Centrale();
        }

        public void SetModules(string[] order)
        {
            this._centrale.Modules = order; 
        }

        public void SetNumberOfUsers(int numberOfUsers)
        {
            this._centrale.NumberOfUsers = numberOfUsers;
        }

        public Centrale GetCentrale()
        {
            return this._centrale;  
        }
    }
}
