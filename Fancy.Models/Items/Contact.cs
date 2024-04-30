using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fancy.Models.Items
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; } = "";

        public string PhoneNumber { get; set; } = "";
        public string Message { get; set; } = "";
        public DateTime DateTime { get; set; }
    }
}
