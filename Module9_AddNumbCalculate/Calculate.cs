using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9_AddNumbCalculate
{
    public class Calculate
    {
        public double AddOperation(double num1, double num2)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.
            result = num1 + num2;
            return result;
        }
    }
}
