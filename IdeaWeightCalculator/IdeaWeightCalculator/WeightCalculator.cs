﻿using System;
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
                    throw new ArgumentException("The Gender is not Valid!");
            }
        }

        public List<double> GetIdealBodyFromDS()
        {
            List<double> result = new List<double>();

            var repo = new WeightRepository();
            var weights = repo.GetWeights();

            foreach (var weight in weights)
            {
                result.Add(weight.GetIdealBodyWeight());
            }

            return result;
        }
    }
}
