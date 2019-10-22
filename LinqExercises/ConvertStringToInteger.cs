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

            return negative
                ? input.Skip(1).Aggregate(0d, (result, c) => (result + (char.GetNumericValue(c) * Math.Pow(10, Convert.ToDouble(input.Length - input.IndexOf(c) - 1))) * -1))
                : input.Aggregate(0d, (result, c) => result + (char.GetNumericValue(c) * Math.Pow(10, Convert.ToDouble(input.Length - input.IndexOf(c) - 1))));
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
