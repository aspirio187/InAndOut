using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Borrower { get; set; }
        public string Lender { get; set; }
        [DisplayName("Item name")]
        public string ItemName { get; set; }
    }
}
