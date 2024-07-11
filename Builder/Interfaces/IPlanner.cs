namespace Builder.Interfaces
{
    public interface IPlanner
    {
        string Name { get; }
        string TechStack { get; }
        int NumberOfUsers { get; }
        string[] Modules { get; }

    }
}
