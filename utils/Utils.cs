using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.utils
{
    internal class Utils : IUtils
    {

        private Dictionary<string, double[]> bmiClass;
        
        public Utils()
        {
            bmiClass = new Dictionary<string, double[]>
            {
                { "Underweight", new double[] { 0, 18.4 } },
                { "Normal Weight", new double[] { 18.5, 24.9 } },
                { "Overweight", new double[] { 25, 29.9 } },
                { "Obesity Class I", new double[] { 30, 34.9 } },
                { "Obesity Class II", new double[] { 35, 39.9 } },
                { "Obesity Class III", new double[] { 40, double.MaxValue } }
            };
        }

        public double cmToMSquared(double cm)
        {
            double m = cm / 100;
            double m2 = Math.Pow(m, 2);

            return m2;
        }

        public string classification(double bmi)
        {
            foreach(var kvp in bmiClass)
            {
                double[] range = kvp.Value;

                if(bmi >= range[0] && bmi <= range[1])
                {
                    return kvp.Key;
                }
            }

            return "Invalid";
        }

    }
}
