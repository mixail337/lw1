using System;

namespace Solvers
{
    public class QuadraticEquationSolver : ISolver
    {
        private double _coefficientA;
        private double _coefficientB;
        private double _coefficientC;
        private object[] _output;

        public void SetInput(object[] parameters)
        {
            _coefficientA = Convert.ToDouble(parameters[0]);
            _coefficientB = Convert.ToDouble(parameters[1]);
            _coefficientC = Convert.ToDouble(parameters[2]);
        }

        public void Run()
        {
            var d = Math.Pow(_coefficientB, 2) - 4 * _coefficientA * _coefficientC;

            if (d < 0)
            {
                _output = new object[]{};

                return;
            }

            _output = new object[2];
            _output[0] = (-_coefficientB + Math.Sqrt(Math.Pow(_coefficientB, 2) - 4 * _coefficientA * _coefficientC)) / (2 * _coefficientA);
            _output[1] = (-_coefficientB - Math.Sqrt(Math.Pow(_coefficientB, 2) - 4 * _coefficientA * _coefficientC)) / (2 * _coefficientA);
        }

        public object[] GetOutput()
        {
            return _output;
        }
    }
}
