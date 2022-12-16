using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solvers;

namespace UnitTests
{
    [TestClass]
    public class TestSolvers
    {
        private void RunTest(ISolver solver, object[] input, object[] expectedOutput)
        {
            solver.SetInput(input);
            solver.Run();

            var actualOutput = solver.GetOutput();

            Assert.AreEqual(expectedOutput.Length, actualOutput.Length);

            for (var index = 0; index < actualOutput.Length; index++)
            {
                Assert.AreEqual(expectedOutput[index], actualOutput[index]);
            }
        }

        private void RunTest(ISolver solver, object[] input, double[] expectedOutput, double delta)
        {
            solver.SetInput(input);
            solver.Run();

            var actualOutput = solver.GetOutput();

            Assert.AreEqual(expectedOutput.Length, actualOutput.Length);

            for (var index = 0; index < actualOutput.Length; index++)
            {
                Assert.AreEqual(expectedOutput[index], (double) actualOutput[index], delta);
            }
        }

        [TestMethod]
        public void TestQuadraticEquationSolver()
        {
            RunTest(new QuadraticEquationSolver(), new object[] { 3.0, 6.0, 2.0 }, new []{ -0.422, -1.577 }, 1.0e-3);
            RunTest(new QuadraticEquationSolver(), new object[] { -1.0, 10.0, -10.0 }, new[] { 1.127, 8.872 }, 1.0e-3);
            RunTest(new QuadraticEquationSolver(), new object[] { 18.0, 19.0, 20.0 }, new double[] { }, 1.0e-3);
            RunTest(new QuadraticEquationSolver(), new object[] { 7.0, 1.0, 2.0 }, new double[] { }, 0.0);
        }
    }
}
