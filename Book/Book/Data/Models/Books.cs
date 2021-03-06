using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.Data.Models
{
    public class Books
    {
        public int id { get; set; }

        public string name { get; set; }

        public string author { get; set; }

        public string shortDesc { get; set; }

        public string img { get; set; }

        public ushort price { get; set; }

        public bool isFavorite { get; set; }

        public bool available { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}
