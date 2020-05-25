using System;
using System.Collections.Generic;

namespace MVCManukauTech.Models.DB
{
    public partial class Category
    {
        public Category()
        {
            Shoes = new HashSet<Shoes>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Shoes> Shoes { get; set; }
    }
}
