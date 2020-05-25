using System;
using System.Collections.Generic;

namespace MVCManukauTech.Models.DB
{
    public partial class Shoes
    {
        public Shoes()
        {
            OrderDetail = new HashSet<OrderDetail>();
            Review = new HashSet<Review>();
        }

        public string ShoesId { get; set; }
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public double? UnitCost { get; set; }
        public string Description { get; set; }
        public bool IsDownload { get; set; }
        public string DownloadFileName { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}
