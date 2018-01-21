using System.Collections.Generic;
using ProductManagement.Models;

namespace ProductManagement.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
     
        Product Create();

        bool Add(Product product);

        bool Delete(string code);

        bool Edit(Product product);
    }
}