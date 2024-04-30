using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    public class ProductReview
    {
        public int ReviewId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; } = "";
        public int ProductId { get; set; }
        public int Id { get; set; }

        public virtual Product? Product { get; set; }
        public DateTime DateTime { get; set; }
    }
}
