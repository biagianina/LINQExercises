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

            var positiveNumber = negative ? input.Skip(1) : input;
            var numericValue = positiveNumber.Aggregate(0d, (result, c) =>
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("Input must be a integer format");
                }

                return result * 10 + char.GetNumericValue(c);
            });

            return negative ? -numericValue : numericValue;
        }
    }
}
