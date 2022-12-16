namespace Solvers
{
    public interface ISolver
    {
        void SetInput(object[] parameters);
        void Run();
        object[] GetOutput();
    }
}