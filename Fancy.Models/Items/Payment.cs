using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string Name { get; set; } = "";

        public string CardNo { get; set; } = "";
        public string ExpiryDate { get; set; } = "";
        public int CvvNo { get; set; }
        public string Address { get; set; } = "";

        public string PaymentMode { get; set; } = "";
        public decimal Total { get; set; }

    }
}
