using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class PrimeNumber
    {
        public string IsPrime(int num)
        {
            if (num < 2)
                return $"Число {num} не является простым";

            int a = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 2; i <= a; ++i)
            {
                if (num % i == 0)
                    return $"Число {num} не является простым";
            }

            return $"Число {num} является простым";
        }
    }
}
