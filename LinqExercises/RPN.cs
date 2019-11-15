using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqExercises
{
    public class RPN
    {
        private readonly string operation;

        public RPN(string operation)
        {
            this.operation = operation;
        }

        public decimal Result()
        {
            var op = operation.Split();
            return op.Aggregate(new decimal[] { }.AsEnumerable(), (result, x) =>
            {
                if (decimal.TryParse(x, out decimal a))
                {
                    return result.Append(a);
                }

                var operationResult = GetResult(result.TakeLast(2).ToArray(), x);

                return result.Take(result.Count() - 2).Append(operationResult);
            }).First();
        }

        private decimal GetResult(decimal[] operands, string x)
        {
            if (x == "+")
            {
                return operands[0] + operands[1];
            }

            if (x == "-")
            {
                return operands[0] - operands[1];
            }

            if (x == "/")
            {
                return operands[0] / operands[1];
            }

            if (x == "*")
            {
                return operands[0] * operands[1];
            }

            return 0;
        }
    }
}
