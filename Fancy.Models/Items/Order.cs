using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    public class Order
    {
       
        public int OrderDetailsId { get; set; }
        public string OrderNo { get; set; } = "";
        public int Quantity { get; set; }
        public string Status { get; set; } = "";
        public int ProductId { get; set; }
        public int PaymentId { get; set; }
        public decimal Total { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Payment? Payment { get; set; }
        public DateTime OrderDate { get; set; }

        public bool IsCancel { get; set; } = false;

        public ICollection<Cart> OrderItems { get; set; } = new HashSet<Cart>();
    }
}
