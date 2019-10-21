using System;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main()
        {
            const string input = "aaabbbcyydpp";
            foreach (var v in input.GroupBy(c => c.ToString(), StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine(v.Key + " " + v.Count());
            }
        }

        private static void Callback(string productName, int numberOfProducts)
        {
            Console.WriteLine($"The stock of {productName} is {numberOfProducts}, you should restock!", productName, numberOfProducts);
        }
    }
}
