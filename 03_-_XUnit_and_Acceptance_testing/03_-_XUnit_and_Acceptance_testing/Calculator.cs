using System;
using System.Collections.Generic;
using System.Text;

namespace _03___XUnit_and_Acceptance_testing
{
    public class Calculator
    {
        public List<StringBuilder> calculations = new List<StringBuilder>();

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

        public void History()
        {
            foreach (var item in calculations)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine();
            }
        }

        public int AdditionMulti(int augend, int[] addends)
        {
            int sum = augend;
            string text = $"{augend}";
            foreach (int addend in addends)
            {
                sum += addend;
                text += $" + {addend}";
            }
            text += $" = {sum}";
            StringBuilder addition = new StringBuilder();
            addition.Append(text);
            calculations.Add(addition);
            return sum;
        }

        public int SubtractionMulti(int minuend, int[] subtrahends)
        {
            int difference = minuend;
            foreach (int subtrahend in subtrahends)
            {
                difference -= subtrahend;
            }
            return difference;
        }

        public int MultiplicationMulti(int multiplicand, int[] multipliers)
        {
            int product = multiplicand;
            foreach (int multiplier in multipliers)
            {
                product *= multiplier;
            }
            return product;
        }

        public int DivisionMulti(int dividend, int[] divisors)
        {
            int quotend = dividend;
            foreach (int divisor in divisors)
            {
                quotend /= divisor;
            }
            return quotend;
        }
    }
}
