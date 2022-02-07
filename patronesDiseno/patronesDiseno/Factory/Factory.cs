using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Factory
{
    // Creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //concret creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            this._extra = extra;
        }
        public override ISale GetSale()
        {
            return new StoreSale(this._extra);
        }
    }

    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal extra)
        {
            this._discount = extra;
        }
        public override ISale GetSale()
        {
            return new InternetSale(this._discount);
        }
    }

    //Concret Product
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale(decimal extra)
        {
            this._extra = extra;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"la venta en tienda tiene un total de {total + this._extra}");
        }
    }

    public class InternetSale : ISale
    {
        private decimal _discount;

        public InternetSale(decimal extra)
        {
            this._discount = extra;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"la venta en tienda tiene un total de {total - this._discount}");
        }
    }

    //Product
    public interface ISale
    {
         void Sell(decimal total);
    }
}
