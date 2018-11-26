using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Summary
    {
        //average calculation
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
        //sum calculation
        public static double Sum(List<string> value)
        {
           double sum = 0;

            foreach (var val in value)
            {
                sum = sum + Double.Parse(val);
            } 

            return sum;
        }
        //max calculation
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
        //min calculation
        public static int Min(List<string> value)
        {
            int minVal = Int32.Parse(value.ElementAt(0));

            for (int i = 0; i < value.Count; i++)
            {
                if (minVal > Int32.Parse(value.ElementAt(i)))
                {
                    minVal = Int32.Parse(value.ElementAt(i));
                }
            }

            return minVal;
        }
        //totaldistnce calculation
        public static double TotalDistance(double average, int count, int interval)
        {
            var time = TimeSpan.FromSeconds(count * interval);
            double total1 = average * time.TotalHours;

            return total1;
        }

    }
}
