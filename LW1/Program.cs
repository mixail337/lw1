using System;
using Solvers;

namespace LW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var quadraticEquationSolver = new QuadraticEquationSolver();
            quadraticEquationSolver.SetInput(new object[]{3, 6, 2});
            quadraticEquationSolver.Run();

            var solution = quadraticEquationSolver.GetOutput();

            Console.WriteLine($"X1: {solution[0]}\n" +
                              $"X2: {solution[1]}");

            Console.ReadLine();
        }
    }
}
