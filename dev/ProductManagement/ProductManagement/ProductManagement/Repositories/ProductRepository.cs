using System;
using System.Collections.Generic;
using System.Linq;
using ProductManagement.Models;
using ProductManagement.Repositories.SampleData;

namespace ProductManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts()
        {
            var products = Datastore.Products;
           
            return products;
        }
        
        public Product Create()
        {
            return new Product();
        }

        public bool Add(Product product)
        {
           throw  new NotImplementedException(nameof (Add));
        }

        public bool Delete(string code)
        {
            throw new NotImplementedException(nameof(Delete));
        }

        public bool Edit(Product product)
        {
            throw new NotImplementedException(nameof(Edit));
        }

        #region Helpers

        private bool Exists(string code)
        {
            return Datastore.Products.Any(e => e.Code.Equals(code));
        }

        #endregion Helpers
    }
}