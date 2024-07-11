namespace Builder.Interfaces
{
    public interface IBuilder
    {
        void SetNumberOfUsers(int numberOfUsers);
        void SetModules(string[] order);
    }
}
