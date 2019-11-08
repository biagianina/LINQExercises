using System.Collections.Generic;
using Xunit;

namespace LinqExercises
{
    public class ProductsFiltersTests
    {
        [Fact]
        public void OneFeatureAtLeastProducts()
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
            var phone = new Product()
            {
                Name = "phone",
                Features = new List<Feature>
                                {
                                 new Feature { Id = 4 },
                                 new Feature { Id = 5 },
                                 new Feature { Id = 6 },
                                 new Feature { Id = 7 }
                                }
            };
            var tv = new Product()
            {
                Name = "plasma",
                Features = new List<Feature>
                                {
                                 new Feature { Id = 5 },
                                 new Feature { Id = 8 },
                                 new Feature { Id = 9 },
                                 new Feature { Id = 10 }
                                }
            };
            var products = new List<Product>
            {
               laptop,
               phone,
               tv
            };

            var productFilters = new ProductsFilters(products);

            var features = new List<Feature>
            {
                 new Feature { Id = 4 },
                 new Feature { Id = 1 },
                 new Feature { Id = 15 },
                 new Feature { Id = 11 }
            };
            var expected = new List<Product>
            {
                laptop,
                phone
            };

            Assert.Equal(expected, productFilters.GetProductsWithAtLeastOneFeature(features));
        }

        [Fact]
        public void AllFeaturesProducts()
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
            var phone = new Product()
            {
                Name = "phone",
                Features = new List<Feature>
                                {
                                 new Feature { Id = 4 },
                                 new Feature { Id = 5 },
                                 new Feature { Id = 6 },
                                 new Feature { Id = 7 }
                                }
            };
            var tv = new Product()
            {
                Name = "plasma",
                Features = new List<Feature>
                                {
                                 new Feature { Id = 5 },
                                 new Feature { Id = 8 },
                                 new Feature { Id = 9 },
                                 new Feature { Id = 10 }
                                }
            };
            var products = new List<Product>
            {
               laptop,
               phone,
               tv
            };

            var productFilters = new ProductsFilters(products);

            var features = new List<Feature>
            {
                 new Feature { Id = 2 },
                 new Feature { Id = 3 }
            };
            var expected = new List<Product> { laptop };

            Assert.Equal(expected, productFilters.GetProductsWithAllFeatures(features));
        }

        [Fact]
        public void WithoutAllFeaturesProducts()
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
            var phone = new Product()
            {
                Name = "phone",
                Features = new List<Feature>
                                {
                                 new Feature { Id = 4 },
                                 new Feature { Id = 5 },
                                 new Feature { Id = 6 },
                                 new Feature { Id = 7 }
                                }
            };
            var tv = new Product()
            {
                Name = "plasma",
                Features = new List<Feature>
                                {
                                 new Feature { Id = 5 },
                                 new Feature { Id = 8 },
                                 new Feature { Id = 9 },
                                 new Feature { Id = 10 }
                                }
            };
            var products = new List<Product>
            {
               laptop,
               phone,
               tv
            };

            var productFilters = new ProductsFilters(products);

            var features = new List<Feature>
            {
                 new Feature { Id = 2 },
                 new Feature { Id = 3 }
            };
            var expected = new List<Product>
            {
               phone,
               tv
            };

            Assert.Equal(expected, productFilters.GetProductsWithoutAllFeatures(features));
        }
    }
}
