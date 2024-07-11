using Builder.Interfaces;

namespace Builder.Director
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder { set { _builder = value; } }

        public void BuildBareBones()
        {
            this._builder.SetModules(new string[] {"administration", "datacom"});
            this._builder.SetNumberOfUsers(1);
        }

        public void BuildFullSuite()
        {
            this._builder.SetModules(new string[] { "administration", "datacom", "calculation", "public transport", "travelerdata", "vehicle data" });
            this._builder.SetNumberOfUsers(10);
        }

    }
}
