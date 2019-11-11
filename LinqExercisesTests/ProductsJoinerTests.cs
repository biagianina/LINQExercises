using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqExercises
{
    public class ProductsJoinerTests
    {
        [Fact]
        public void OneProductJoined()
        {
            var laptop = new Prod { Name = "laptop", Quantity = 10 };
            var phone = new Prod { Name = "mobile phone", Quantity = 5 };
            var tv = new Prod { Name = "TV", Quantity = 6 };
            var console = new Prod { Name = "console", Quantity = 7 };
            var microvawe = new Prod { Name = "microwave", Quantity = 11 };
            var mixer = new Prod { Name = "mixer", Quantity = 5 };
            var shaker = new Prod { Name = "shaker", Quantity = 6 };
            var refrigerator = new Prod { Name = "refrigerator", Quantity = 7 };
            var owen = new Prod { Name = "owen", Quantity = 11 };
            var laptop2 = new Prod { Name = "laptop", Quantity = 20 };
            var list1 = new List<Prod>
            {
                laptop,
                phone,
                tv,
                console,
                microvawe
            };

            var list2 = new List<Prod>
            {
                laptop,
                mixer,
                shaker,
                refrigerator,
                owen
            };

            var result = new ProductsJoiner(list1, list2);
            var expected = new List<Prod>
            {
                laptop2,
                phone,
                tv,
                console,
                microvawe,
                mixer,
                shaker,
                refrigerator,
                owen
            };

            Assert.Equal(expected, result.JoinProducts());
        }
    }
}
