using Book.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Data.Interfaces
{
    public interface IAllBooks
    {
        IEnumerable<Books> Books { get; }
        IEnumerable<Books> getFavBooks { get; set; }
        Books getObjectBook(int bookId);
    }
}
