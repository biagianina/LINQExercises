using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    class Program
    {
        public static void Main()
        {
            var list1 = new List<Prod>
            {
                new Prod { Name = "laptop", Quantity = 10 },
                new Prod { Name = "mobile phone", Quantity = 5 },
                new Prod { Name = "TV", Quantity = 6 },
                new Prod { Name = "console", Quantity = 7 },
                new Prod { Name = "microwave", Quantity = 11 }
            };

            var list2 = new List<Prod>
            {
                new Prod { Name = "laptop", Quantity = 10 },
                new Prod { Name = "mixer", Quantity = 5 },
                new Prod { Name = "shaker", Quantity = 6 },
                new Prod { Name = "refrigerator", Quantity = 7 },
                new Prod { Name = "owen", Quantity = 11 }
            };

            var result = new ProductsJoiner(list1, list2);

            foreach (var v in result.JoinProducts())
            {
                Console.WriteLine(v.Name + " " + v.Quantity);
            }
        }
    }
}
