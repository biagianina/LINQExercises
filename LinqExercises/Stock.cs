using System;
using System.Collections.Generic;

namespace LinqExercises
{
    public class Stock
    {
        readonly Dictionary<string, Dictionary<string, int>> stock;
        readonly Action<string, int> callback;

        public Stock(Action<string, int> callback)
        {
            stock = new Dictionary<string, Dictionary<string, int>>();
            this.callback = callback;
        }

        public void Add(string category, string productName, int numberOfProducts)
        {
            if (stock.TryGetValue(category, out Dictionary<string, int> productsInCategory))
            {
                if (productsInCategory.TryGetValue(productName, out int productsNumber))
                {
                    productsInCategory[productName] = productsNumber + numberOfProducts;
                }
                else
                {
                    stock[category].Add(productName, numberOfProducts);
                }
            }
            else
            {
                stock.Add(category, new Dictionary<string, int> { { productName, numberOfProducts } });
            }
        }

        public void Remove(string category, string product, int numberOfProducts)
        {
            if (stock.TryGetValue(category, out Dictionary<string, int> productsInCategory) &&
                productsInCategory.TryGetValue(product, out int productsInStock))
            {
                productsInCategory[product] = productsInStock - numberOfProducts;
                CheckStock(productsInStock, productsInCategory[product], product);
            }
        }

        private void CheckStock(int productsInStock, int productsRemained, string product)
        {
            if (productsRemained < 2 && productsInStock > 2)
            {
                callback(product, productsRemained);
            }

            if (productsRemained < 5 && productsInStock > 5)
            {
                callback(product, productsRemained);
            }

            if (productsRemained < 10 && productsInStock > 10)
            {
                callback(product, productsRemained);
            }
        }
    }
}
