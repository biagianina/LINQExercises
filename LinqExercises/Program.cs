using System;

namespace LinqExercises
{
    class Program
    {
        static void Main()
        {
            var stock = new Stock(Callback);
            stock.Add("fruits", "banana", 30);
            stock.Add("fruits", "orange", 50);
            stock.Add("fruits", "kiwi", 28);
            stock.Remove("fruits", "banana", 28);
            stock.Remove("fruits", "kiwi", 2);
            stock.Add("fruits", "banana", 28);
            stock.Remove("fruits", "banana", 22);
            stock.Remove("fruits", "banana", 1);
            stock.Add("cereals", "Cookie Crisps", 12);
            stock.Remove("cereals", "Cookie Crisps", 10);
        }

        private static void Callback(string productName, int numberOfProducts)
        {
            Console.WriteLine($"The stock of {productName} is {numberOfProducts}, you should restock!", productName, numberOfProducts);
        }
    }
}
