using System;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main()
        {
            var result = new SignsOrder(2, 3);
            foreach (var r in result.GenerateEquations())
            {
                Console.WriteLine(r);
            }
        }
    }
}
