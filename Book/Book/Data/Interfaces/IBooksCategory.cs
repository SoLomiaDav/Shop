using Book.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Data.Interfaces
{
    public interface IBooksCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
