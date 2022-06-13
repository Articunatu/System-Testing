using System;
using System.Collections.Generic;
using System.Text;

namespace XUnit_Calculator
{
    public class Calculator
    {
        List<StringBuilder> calculations = new List<StringBuilder>();
        public int Addition(int augend, int addend)
        {
            int sum = augend + addend;

            StringBuilder addition = new StringBuilder();
            addition.Append($"{augend} + {addend} = {sum}");
            calculations.Add(addition);

            return sum;
        }

        public int Subtraction(int minuend, int subtrahend)
        {
            int difference = minuend - subtrahend;

            StringBuilder subtraction = new StringBuilder();
            subtraction.Append($"{minuend} - {subtrahend} = {difference}");
            calculations.Add(subtraction);

            return difference;
        }

        public int Multiplication(int multiplicand, int multiplier)
        {
            int product = multiplicand * multiplier;

            StringBuilder multiplication = new StringBuilder();
            multiplication.Append($"{multiplicand} * {multiplier} = {product}");
            calculations.Add(multiplication);

            return product;
        }

        public int Division(int dividend, int divisor)
        {
            int quotend = dividend / divisor;

            StringBuilder division = new StringBuilder();
            division.Append($"{dividend} / {divisor} = {quotend}");
            calculations.Add(division);

            return quotend;
        }
    }
}
