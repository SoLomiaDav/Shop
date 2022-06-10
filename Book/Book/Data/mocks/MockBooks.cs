using Book.Data.Interfaces;
using Book.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Data.mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory();

        public IEnumerable<Books> Books
        {
            get {
                return new List<Books>
                {
                    new Books {name = "Дюна", author = "Френк Герберт", shortDesc = "", img = "", price = 150, isFavorite = true, available = true, Category = _categoryBooks.AllCategories.First()}
                };
            }
                }
        public IEnumerable<Books> getFavBooks { get; set; }
        public Books getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
