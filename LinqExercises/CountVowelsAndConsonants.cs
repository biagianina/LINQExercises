using System.Linq;

namespace LinqExercises
{
    public class CountVowelsAndConsonants
    {
        readonly string input;
        readonly string vowels = "aeiou";

        public CountVowelsAndConsonants(string input)
        {
            this.input = input;
        }

        public (int, int) VowelsAndConsonantsCounter()
        {
            return input.Aggregate((0, 0), (count, c) =>
            {
                  if (vowels.Contains(char.ToLower(c)))
                  {
                      count.Item1++;
                  }
                  else if (char.IsLetter(c))
                  {
                      count.Item2++;
                  }

                  return count;
            });
        }
    }
}
