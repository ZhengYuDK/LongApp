using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LongApp.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryId =1, CategoryName="Milk", Description="Milk description"},
                    new Category{CategoryId =2, CategoryName="Health", Description="Health description"}
                };
            }
        }
    }
}
