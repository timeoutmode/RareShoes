using System;
using System.Collections.Generic;

namespace MVCManukauTech.Models.DB
{
    public partial class Review
    {
        public int ReviewId { get; set; }
        public string ShoesId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int? Rating { get; set; }
        public string Comments { get; set; }

        public virtual Shoes Shoes { get; set; }
    }
}
