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

                if (x == "+")
                {
                    var operands = result.TakeLast(2).ToArray();
                    var sum = operands[0] + operands[1];
                    return result.Take(result.Count() - 2).Append(sum);
                }

                if (x == "-")
                {
                    var operands = result.TakeLast(2).ToArray();
                    var dif = operands[0] - operands[1];
                    return result.Take(result.Count() - 2).Append(dif);
                }

                if (x == "/")
                {
                    var operands = result.TakeLast(2).ToArray();
                    var div = operands[0] / operands[1];
                    return result.Take(result.Count() - 2).Append(div);
                }

                if (x == "*")
                {
                    var operands = result.TakeLast(2).ToArray();
                    var prod = operands[0] * operands[1];
                    return result.Take(result.Count() - 2).Append(prod);
                }

                return result;
            }).First();
        }
    }
}
