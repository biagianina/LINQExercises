using System;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main()
        {
            var input = new Palindromes("aba");
            foreach (var s in input.GetPalindromes())
            {
                Console.WriteLine(s);
            }
        }
    }
}
