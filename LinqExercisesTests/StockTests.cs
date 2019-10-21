using Xunit;

namespace LinqExercises
{
    public class StockTests
    {
        string name;
        int number;

        public void Callback(string product, int numberOfProducts)
        {
            this.name = product;
            this.number = numberOfProducts;
        }

        [Fact]
        public void TestStock()
        {
            var stock = new Stock(Callback);
            stock.Add("fruits", "banana", 30);
            stock.Add("fruits", "orange", 50);
            stock.Add("fruits", "kiwi", 28);
            stock.Remove("fruits", "banana", 28);
            Assert.Equal("banana", name);
            Assert.Equal(2, number);

            stock.Remove("fruits", "kiwi", 12);
            stock.Add("fruits", "banana", 28);
            stock.Remove("fruits", "banana", 22);
            Assert.Equal("banana", name);
            Assert.Equal(8, number);

            stock.Remove("fruits", "banana", 1);
            Assert.Equal("banana", name);
            Assert.Equal(8, number);

            stock.Add("cereals", "Cookie Crisps", 12);
            stock.Remove("cereals", "Cookie Crisps", 3);
            Assert.Equal("Cookie Crisps", name);
            Assert.Equal(9, number);

            stock.Remove("cereals", "Cookie Crisps", 5);
            Assert.Equal("Cookie Crisps", name);
            Assert.Equal(4, number);

            stock.Remove("cereals", "Cookie Crisps", 1);
            Assert.Equal("Cookie Crisps", name);
            Assert.Equal(4, number);
        }
    }
}
