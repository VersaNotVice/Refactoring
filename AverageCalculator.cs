using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RppoonRefactoring
{
    class AverageCalculator
    {
        public double CalculateAverage(double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++) sum += numbers[i];

            return sum/numbers.Length;
    }
        public List<double> AddAverage(List<double[]> Arrays)
        {
            List<double> averages = new List<double>(); 
            foreach (double[] array in Arrays)
            {
                averages.Add(CalculateAverage(array));
            }
            return averages;
        }
    }
}
