using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaWeightCalculator
{
    public class WeightCalculator
    {
        public double Height { get; set; }

        public char Gender { get; set; }

        public double GetIdealBodyWeight()
        {
            switch (Gender)
            {
                case 'm':
                    return (Height - 100) - ((Height - 150) / 4);
                case 'f':
                    return (Height - 100) - ((Height - 150) / 2);
                default:
                    return 0;
            }
        }
    }
}
