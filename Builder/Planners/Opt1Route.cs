using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Planners
{
    public class Opt1Route : IPlanner
    {
        public string Name { get; } = "Opt1Route";

        public string TechStack { get; } = ".NET";

        public int NumberOfUsers { get; set; } = 0;

        public string[]? Modules {get; set; }
    }
}
