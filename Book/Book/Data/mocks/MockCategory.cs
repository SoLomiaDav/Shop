using Book.Data.Interfaces;
using Book.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Data.mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get { 
                return new List<Category>{
                    new Category { categoryName = "Тверда обкладинка", desc = "Запобігає залому книги" },
                    new Category { categoryName = "М'яка обкладинка", desc = "Зручна для переносу" }
                };            
            }
        }
    }
}
