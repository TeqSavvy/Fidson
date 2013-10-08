using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fidson.Controllers
{
    class ProductController
    {

        public void AddProduct(Product product)
        {
            var dbContext = new DatabaseContext();
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                var dbContext = new DatabaseContext();
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
            }
            catch (Exception exception)
            {
              
            }
        
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var dbContext = new DatabaseContext();
            return dbContext.Products;
        }
    }
}
