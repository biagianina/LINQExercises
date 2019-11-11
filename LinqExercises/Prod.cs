using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace LinqExercises
{
    public class Prod : IEqualityComparer<Prod>
    {
        public string Name;

        public int Quantity;

        public bool Equals(Prod x, Prod y)
        {
            return x.Name.Equals(y.Name) &&
                x.Quantity.Equals(y.Quantity);
        }

        public int GetHashCode(Prod obj)
        {
            return obj.GetHashCode();
        }
    }
}