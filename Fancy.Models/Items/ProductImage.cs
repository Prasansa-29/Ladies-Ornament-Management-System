using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    public class ProductImage
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; } = "";
        public int ProductId { get; set; }
        public virtual Product? Product { get; set; }
        public bool DefaultImage { get; set; }

    }
}
