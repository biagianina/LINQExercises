using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        public static void Main()
        {
            var laptop = new Product()
            {
                Name = "laptop",
                Features = new List<Feature>
                                {
                                 new Feature { Id = 1 },
                                 new Feature { Id = 2 },
                                 new Feature { Id = 3 },
                                 new Feature { Id = 4 }
                                }
            };

            var features = new List<Feature>
            {
                 new Feature { Id = 2 },
                 new Feature { Id = 3 }
            };

            Console.WriteLine(laptop.Features.All(x => features.Any(f => !x.Id.Equals(f.Id))));
        }
    }
}
