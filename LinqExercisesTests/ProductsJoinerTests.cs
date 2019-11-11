using System;
using System.Collections.Generic;
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
            var joined = result.JoinProducts();
            Func<Prod, Prod, bool> equalProducts = (x, y) => x.Name.Equals(y.Name) && x.Quantity.Equals(y.Quantity);
            Assert.True(equalProducts(expected[0], joined[0]));
            Assert.True(equalProducts(expected[1], joined[1]));
            Assert.True(equalProducts(expected[2], joined[2]));
            Assert.True(equalProducts(expected[3], joined[3]));
            Assert.True(equalProducts(expected[4], joined[4]));
            Assert.True(equalProducts(expected[5], joined[5]));
            Assert.True(equalProducts(expected[6], joined[6]));
            Assert.True(equalProducts(expected[7], joined[7]));
            Assert.True(equalProducts(expected[8], joined[8]));
        }

        [Fact]
        public void MultipleProductsJoined()
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
            var phone2 = new Prod { Name = "mobile phone", Quantity = 10 };
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
                phone,
                mixer,
                shaker,
                refrigerator,
                owen
            };

            var result = new ProductsJoiner(list1, list2);
            var expected = new List<Prod>
            {
                laptop2,
                phone2,
                tv,
                console,
                microvawe,
                mixer,
                shaker,
                refrigerator,
                owen
            };
            var joined = result.JoinProducts();
            Func<Prod, Prod, bool> equalProducts = (x, y) => x.Name.Equals(y.Name) && x.Quantity.Equals(y.Quantity);
            Assert.True(equalProducts(expected[0], joined[0]));
            Assert.True(equalProducts(expected[1], joined[1]));
            Assert.True(equalProducts(expected[2], joined[2]));
            Assert.True(equalProducts(expected[3], joined[3]));
            Assert.True(equalProducts(expected[4], joined[4]));
            Assert.True(equalProducts(expected[5], joined[5]));
            Assert.True(equalProducts(expected[6], joined[6]));
            Assert.True(equalProducts(expected[7], joined[7]));
            Assert.True(equalProducts(expected[8], joined[8]));
        }
    }
}
