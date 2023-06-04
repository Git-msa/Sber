using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Factorial
    {
        public string CalculateFactorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Число не должно быть отрицательным");

            if (n == 0 || n == 1)
                return $"Факториал числа {n} равен 1";

            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return $"Факториал числа {n} равен {factorial}";
        }
    }
}
