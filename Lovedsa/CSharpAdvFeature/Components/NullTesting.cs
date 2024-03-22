using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvFeature.Components
{
    public class NullTesting
    {

        public double SumNumbers(List<double[]> setsOfNumbers, int indexOfSetToSum)
        {
            return setsOfNumbers?[indexOfSetToSum]?.Sum() ?? double.NaN;

        }


    }
}
