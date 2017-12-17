using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongApp.Models
{
    public class MockProductRepository:IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product{ ProductId =1, Name ="product 1", Price=15.95M},
                    new Product{ ProductId =2, Name ="product 2", Price=25.95M}
                };
            }
        }

       public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
