using Builder.Interfaces;

namespace Builder.Planners
{
    public class Centrale : IPlanner
    {
        public string Name { get;  } = "Cabman Centrale";

        public string TechStack { get; } = "Delphi";

        public int NumberOfUsers { get; set; } = 0;

        public string[]? Modules { get; set;}
    }
}
