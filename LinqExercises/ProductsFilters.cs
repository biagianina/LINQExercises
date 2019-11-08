using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercises
{
    public class ProductsFilters
    {
        readonly IEnumerable<Product> products;

        public ProductsFilters(IEnumerable<Product> products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetProductsWithAtLeastOneFeature(IEnumerable<Feature> features)
        {
            return products.Where(x => x.Features.Any(x => features.Any(f => f.Id.Equals(x.Id))));
        }

        public IEnumerable<Product> GetProductsWithAllFeatures(IEnumerable<Feature> features)
        {
            return products.Where(x => features.All(f => x.Features.Any(x => x.Id.Equals(f.Id))));
        }

        public IEnumerable<Product> GetProductsWithoutAllFeatures(IEnumerable<Feature> features)
        {
            return products.Where(x => features.All(f => x.Features.All(x => !x.Id.Equals(f.Id))));
        }
    }
}
