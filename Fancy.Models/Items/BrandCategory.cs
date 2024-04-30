using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    public class BrandCategory
    {
        public int BrandCategoryId { get; set; }
        public string BrandName { get; set; }
        public string BrandImageUrl { get; set; }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
