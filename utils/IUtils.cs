using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.utils
{
    internal interface IUtils
    {
        public double cmToMSquared(double cm);
        public string classification(double bmi);
    }
}
