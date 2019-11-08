using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExercises
{
    public class Product
    {
        public string Name { get; set; }

        public ICollection<Feature> Features { get; set;  }
    }
}
