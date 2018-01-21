using System.Collections.Generic;
using ProductManagement.Models;

namespace ProductManagement.Repositories.SampleData
{
    public static class Datastore
    {
        private static List<Product> _products;

        public static List<Product> Products
        {
            get
            {
                if (_products == null)
                {
                    _products = new List<Product>
                    {
                        new Product{Code = "CBM2011",Name = "2011 - Cabernet Sauvignon Merlot",Price = 35},
                        new Product{Code = "CPR2011",Name = "2011 - Cricket Pitch Red",Price = 20},
                        new Product {Code = "PN2012", Name = "2012 - Pinor PN2012",  Price = 35},
                        new Product{Code = "QS2012",Name = "2012 - Quail Shiraz",Price = 100}
                    };
                }

                return _products;
            }
        }
        
    }
}