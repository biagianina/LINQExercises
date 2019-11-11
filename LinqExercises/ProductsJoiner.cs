using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    public class ProductsJoiner
    {
        private readonly List<Prod> list1;
        private readonly List<Prod> list2;

        public ProductsJoiner(List<Prod> list1, List<Prod> list2)
        {
            this.list1 = list1;
            this.list2 = list2;
        }

        public IEnumerable<Prod> JoinProducts()
        {
            return list1.Concat(list2).GroupBy(x => x.Name).Select(x =>
            new Prod { Name = x.Key, Quantity = x.Select(x => x.Quantity).Aggregate((sum, x) => sum + x) }).ToList();
        }
    }
}
