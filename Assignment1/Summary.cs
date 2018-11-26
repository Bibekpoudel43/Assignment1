using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Summary
    {
    
        public static double Average(List<string> value)
        {
            double sum = 0;

            foreach (var val in value)
            {
                sum = sum + double.Parse(val);
            }

            double result  = (sum / value.Count);
            return result;
        }

        public static double Sum(List<string> value)
        {
           double sum = 0;

            foreach (var val in value)
            {
                sum = sum + Double.Parse(val);
            } 

            return sum;
        }
        public static double Max(List<string> value)
        {
            double maxVal = 0;

            for (int i = 0; i < value.Count; i++)
            {
                if (maxVal < double.Parse(value.ElementAt(i)))
                {
                    maxVal = double.Parse(value.ElementAt(i));
                }
            }

            return maxVal;
        }

        public static double Min(List<string> value)
        {
            double minVal = double.Parse(value.ElementAt(0));

            for (int i = 0; i < value.Count; i++)
            {
                if (minVal > double.Parse(value.ElementAt(i)))
                {
                    minVal = double.Parse(value.ElementAt(i));
                }
            }

            return minVal;
        }

    }
}
