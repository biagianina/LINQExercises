using System;
using System.Linq;

namespace LinqExercises
{
    public class ConvertStringToInteger
    {
        private readonly string input;

        public ConvertStringToInteger(string input)
        {
            this.input = input;
        }

        public double GetIntegerValue()
        {
            bool negative = input.StartsWith('-');

            CheckDigits(input, negative);

            var positiveNumber = negative ? input.Skip(1) : input;
            var numericValue = positiveNumber.Aggregate(0d, (result, c) =>
            result * 10 + char.GetNumericValue(c));

            return negative ? -numericValue : numericValue;
        }

        private void CheckDigits(string input, bool negative)
        {
            if (negative && !input.Skip(1).All(c => char.IsDigit(c)) ||
                !negative && !input.All(c => char.IsDigit(c)))
            {
                throw new ArgumentException("Input must be a integer format");
            }
        }
    }
}
