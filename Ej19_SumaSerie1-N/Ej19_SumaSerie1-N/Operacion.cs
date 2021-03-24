using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej19_SumaSerie1_N
{
    class Operacion
    {
        public double AddSum(double n)
        {
            double a = 0;

            for (double i = 1; i < n; i++)
            {
                if (i % 1 == 0)
                {
                    a += 1 / (i + 1); 
                }
        }
            return a;
        }
}
}

