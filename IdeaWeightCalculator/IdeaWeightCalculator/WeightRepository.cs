﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaWeightCalculator
{
    public class WeightRepository
    {
        IEnumerable<WeightCalculator> weights;

        public WeightRepository()
        {
            weights = new List<WeightCalculator>()
            {
                new WeightCalculator{Height = 175, Gender = 'f'}, /// 62.5
                new WeightCalculator{Height = 167, Gender = 'm'}, /// 62.75
                new WeightCalculator{Height = 182, Gender = 'm'}  /// 74
            };
        }

        public IEnumerable<WeightCalculator> GetWeights()
        {
            return weights;
        }
    }
}
