using System;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        static void Main()
        {
            var input = new FirstUnique("aaabbbcyydpp");
            Console.WriteLine(input.GetFirstUnique());
        }
    }
}
