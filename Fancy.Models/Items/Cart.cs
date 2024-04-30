using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string? Id { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public Product? Products { get; set; }


    }
}
