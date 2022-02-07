using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.InjectionDependency
{
    class DrinkWithBeer
    {
        private Beer _beer ;

        private decimal _water;
        private decimal _sugar;

        public DrinkWithBeer(decimal water, decimal sugar, Beer beer)
        {
            _sugar = sugar;
            _water = water;
            _beer = beer;
        }

        public void build()
        {
            Console.WriteLine($"preparamos una bebida que tiene agua un {_water} porciento y azucar un {_sugar} porciento");
        }

    }
}
