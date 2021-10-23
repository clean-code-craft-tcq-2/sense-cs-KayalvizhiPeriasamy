using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
         public class Stats
        {
            public float Average;
            public float Maximum;
            public float Minimum;
        }

        public class EmailAlert
        {
            bool emailSent = false;
        }

        public class LEDAlert
        {
            bool ledGlows = false;
        }

        
          public Stats CalculateStatistics(List<float> numbers)
        {
            //Implement statistics here           
            Stats obj = new Stats();
            var length = numbers.Count;
            if (length != 0)
            {
                obj.Average = numbers.Sum() / length;
                obj.Maximum = numbers.Max();
                obj.Minimum = numbers.Min();
            }

            else
            {
                obj.Average = Single.NaN;
                obj.Maximum = Single.NaN;
                obj.Minimum = Single.NaN;
            }

            return obj;
        }
    }
}
